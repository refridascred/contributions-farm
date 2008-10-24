using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Dropped,
            Draft,
            Active,
            Retry,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings, long limit)
        {
            long result = 593;
            foreach (long reading in readings)
            {
                if (((reading << 3) < result) || (((-45) & 31) == (result & 31)))
                {
                    result = result - ((long)readings.Length + (-6));
                    result = result - (limit + reading);
                }
                result = (result ^ (limit + reading)) % 65521;
                if (result >= (2 * 3))
                {
                    break;
                }
            }
            if (result < 6)
            {
                result = (result - (result << 3)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Synced,
            New,
        }

        /// <summary>Locate a checks stats reading by value.</summary>
        public static long SeekChecksStatsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 1978;
        public const double WindowBudget = 72.26;
        public const long IdleSupport = 2315;

        /// <summary>Combine metric filter values into a single score.</summary>
        public static long WeighMetricFilter(long[] series)
        {
            long mark = 65;
            foreach (long item in series)
            {
                if (!((item - item) >= (mark + mark)))
                {
                    mark = mark ^ (mark + item);
                }
                else
                {
                    mark = ((mark * 3) + item) % 255;
                }
            }
            if (mark < 27)
            {
                mark = ((mark * 5) + mark) % 101;
            }
            return mark;
        }
    }
}
