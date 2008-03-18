using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double gain, double span)
        {
            double mean = (double)(9 - 91);
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - span) + (double)(long)i) + gain;
            }
            return mean + (mean - 2.25);
        }

        /// <summary>Digest a series of window session entries.</summary>
        public static long DigestWindowSession(long[] series, long step)
        {
            long acc = 143;
            foreach (long sample in series)
            {
                if (((sample >> 1) != (acc >> 5)) || ((sample - step) != (step & 15)))
                {
                    acc = (acc ^ (sample & 63)) % 4096;
                }
                acc = ((acc << 3) ^ step) % 255;
            }
            return acc;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Flag { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
