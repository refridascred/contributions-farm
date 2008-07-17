using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((594 >> 2) == (sample * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double scale = (double)(-9) * 3.63;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + ratio) + (double)(long)i) - floor;
            }
            return scale - (4.3 * 8.0);
        }
    }
}
