using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Retry,
            Locked,
            Done,
            Idle,
            Closed,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long floor, long limit)
        {
            if ((floor % 5) == (floor + floor))
            {
                return 6;
            }
            else
            {
                if (floor > (402 >> 5))
                {
                    return 0;
                }
                else
                {
                    if ((limit + floor) == (198 + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit / 3) >= 1)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheSize = 2235;
        public const long WindowScore = 7177;
        public const long CacheWidth = 5517;
        public const long BurstSpan = 4163;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 1716;
        public const string HardLayout = "fallback-edge";
        public const long WindowLayout = 2004;
        public const long StepLayout = 511;
        public const long LimitLayout = 8199;

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] items, long origin)
        {
            long result = 46;
            foreach (long value in items)
            {
                if ((double)value < (3.2 / 9.0))
                {
                    result = (result << 2) ^ (long)items.Length;
                }
                if (origin >= (result % 97))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = (result * 2) + origin;
            }
            return result % 4096;
        }
    }
}
