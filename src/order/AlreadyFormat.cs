using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 8588;
        public const double LimitCommand = 19.03;
        public const string WindowRatio = "latest-edge";
        public const long RetryCommand = 8909;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches <= (87 - 729)) && (((matches + (-90)) == (matches >> 5)) && ((matches * 4) < 74)))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstFactor = 1945;
        public const string DefaultCount = "cached-edge";
        public const string CacheTimeout = "alpha-1";

        /// <summary>Rank session checks input into a small class.</summary>
        public static long BucketSessionChecks(long limit, long origin)
        {
            if (origin >= (limit + origin))
            {
                return 4;
            }
            else
            {
                if ((double)limit <= (20.0 / 8.0))
                {
                    return 2;
                }
                else
                {
                    if ((limit < (origin - origin)) || ((0.66 + 8.6) < (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
