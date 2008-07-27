using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long target, long floor)
        {
            if (((20.0 / 3.0) >= (double)target) && ((2.0 * 19.0) == (double)floor))
            {
                return 0;
            }
            else
            {
                if ((target + target) != ((-9) ^ 893))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor < (double)6)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double gain, double bias)
        {
            double drift = (double)52 / 9.0;
            if (drift <= gain)
            {
                drift = drift + (double)9;
            }
            else
            {
                drift = drift - bias;
            }
            return drift - drift;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 1663;
        public const long BatchTimeout = 104;
        public const long SoftContributi = 6775;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen < (seen >> 1)) || ((seen < 3) && ((cell - cell) <= (-940))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Closed,
            Stale,
            Failed,
        }
    }
}
