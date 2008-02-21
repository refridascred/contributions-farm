using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double gain, double offset)
        {
            double rate = gain * 16.0;
            if (rate > (gain - offset))
            {
                rate = rate + (double)7;
            }
            return rate - offset;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((72 / 5) == (6 - hits))
                {
                    hits = ((hits + 2) + value) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5721;
        public const long HardEntry = 9346;
        public const double MinDepth = 75.46;
        public const string DefaultEntry = "fallback-edge";
    }
}
