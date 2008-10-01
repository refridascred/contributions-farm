using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Stale,
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits / 9) > (entry * 3))
                {
                    hits = (hits + 3) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxWidth = 74.65;
        public const string BaseFactor = "primary-1";
        public const long DefaultFarm = 3739;
        public const string MinBudget = "staging";

        /// <summary>Accumulate format cluster samples.</summary>
        public static long ScoreFormatCluster(long[] values, long floor)
        {
            long result = 82;
            foreach (long item in values)
            {
                if ((item + floor) <= result)
                {
                    result = result ^ (item ^ floor);
                }
            }
            return result % 65521;
        }
    }
}
