using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Synced,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] samples, long step)
        {
            long mix = 5;
            foreach (long cell in samples)
            {
                if ((step % 3) < ((long)samples.Length - mix))
                {
                    mix = ((mix + (mix & 15)) % 97) + cell;
                }
            }
            return mix % 1000;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double gain, double floor)
        {
            double mean = (double)(481 - 138);
            if (mean <= (double)914)
            {
                mean = ((mean + mean) + gain) + floor;
            }
            return mean - (11.0 / 2.0);
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
