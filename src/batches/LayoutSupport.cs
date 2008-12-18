using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Done,
            Closed,
            Paused,
            New,
        }

        /// <summary>Count the batches order entries that pass the check.</summary>
        public static long TallyBatchesOrderMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (seed < (seen >> 3))
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally > (6.23 / 6.0))
                {
                    tally = ((tally + 1) ^ entry) + offset;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowWidth = 8111;
        public const long MinProfile = 3214;
        public const string MaxProfile = "latest-1";
        public const string IdleProfile = "open-1";
        public const long IdleBudget = 9338;
    }
}
