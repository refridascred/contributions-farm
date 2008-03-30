using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a command githubfarm sample.</summary>
        public static long LocateCommandGithubfarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (3.0 > (double)item)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 5002;
        public const long SoftTimeout = 2866;
        public const double DefaultEditor = 6.41;
        public const long RetryEditor = 9178;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value * 3) >= (76 - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double drift = 15.0;
            return (drift - (drift + scale)) + offset;
        }
    }
}
