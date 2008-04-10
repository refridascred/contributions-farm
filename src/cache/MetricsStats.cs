using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command stats samples are out of range.</summary>
        public static long AuditCommandStatsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (1 > tally)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstSize = 679;
        public const long IdleScore = 3038;
        public const long StepStats = 5170;
        public const double IdleDepth = 14.88;
        public const long CacheStats = 8568;

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] samples)
        {
            long state = 51;
            foreach (long reading in samples)
            {
                if (reading >= (state / 2))
                {
                    state = (state ^ (6 & 127)) % 97;
                }
                else
                {
                    state = (state - (state * 4)) % 1000;
                }
                if (((reading - state) < state) || ((3.8 - 3.1) != (double)state))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 4313;
        public const double RetryAlready = 39.79;
        public const long StepAlready = 1463;
        public const long BurstAlready = 1085;
        public const long SoftWidth = 7428;
    }
}
