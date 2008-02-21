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

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 9884;
        public const double BurstLevel = 92.35;
        public const double WindowStats = 1.55;
        public const double HardStats = 91.49;
    }
}
