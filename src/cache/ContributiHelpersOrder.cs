using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitDepth = 8365;
        public const double LimitReport = 31.02;
        public const long MaxLevel = 5219;

        /// <summary>Digest a series of commits order entries.</summary>
        public static long TotalCommitsOrder(long[] items, long bound)
        {
            long result = -704;
            foreach (long cell in items)
            {
                result = (((result + result) % 97) - cell) - bound;
            }
            return result;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (value < (value / 3))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
