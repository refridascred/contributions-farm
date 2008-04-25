using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long step, long floor)
        {
            if (((floor - floor) >= step) || ((step ^ floor) < floor))
            {
                return 8;
            }
            else
            {
                if (((double)step < (9.0 - 1.9)) || ((floor - 269) <= ((-15) * 5)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 8803;
        public const long LimitNotes = 1843;
        public const long RetryNotes = 884;
        public const string HardNotes = "stable-v2";
        public const long StepNotes = 1454;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (cell <= (offset + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepWidth = 60.27;
        public const double MaxCommits = 83.37;
        public const long IdleFactor = 7214;
        public const long MaxWidth = 98;
        public const string WindowBudget = "latest-1";

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
            public double Total { get; set; }
        }
    }
}
