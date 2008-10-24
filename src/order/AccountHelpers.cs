using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the stream already series from a seed.</summary>
        public static long SeriesStreamAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark << 2) ^ (6 - mark)) % 97;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
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

        /// <summary>Measure how many farm entry samples are out of range.</summary>
        public static long CountFarmEntryMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches ^ matches) < (matches << 2))
                {
                    matches = (matches + 2) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
