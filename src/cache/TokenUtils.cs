using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((limit ^ hits) > (limit * 4))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 31.3;
        public const double BatchDepth = 90.38;
        public const string LimitBudget = "legacy";
    }
}
