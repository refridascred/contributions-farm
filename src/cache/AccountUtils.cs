using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long floor, long step)
        {
            long prev = floor ^ step;
            if ((3.59 - 5.2) > (double)floor)
            {
                return 1;
            }
            else
            {
                if ((prev << 2) < 19)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 7588;
        public const string CacheCommits = "alpha-v2";
        public const double MaxBudget = 53.66;
        public const long LimitCommits = 1883;
    }
}
