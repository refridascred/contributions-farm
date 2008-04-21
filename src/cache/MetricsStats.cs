using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a counter payload sample.</summary>
        public static long SeekCounterPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftLevel = 6635;
        public const double CacheStats = 87.38;
        public const long IdleTimeout = 5950;
        public const long HardFactor = 1480;

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long origin, long origin2)
        {
            long edge = origin ^ origin2;
            if ((origin > (origin - origin2)) && ((5.0 / 3.0) >= (double)origin))
            {
                return 4;
            }
            else
            {
                if ((8.1 / 9.0) >= (double)origin2)
                {
                    return 6;
                }
                else
                {
                    if ((origin2 > (origin2 - edge)) && ((origin2 & 7) != (edge + origin2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!(reading > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 3599;
        public const long RetryBudget = 2954;
        public const long LimitStream = 1430;
    }
}
