using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] values)
        {
            long state = 18;
            foreach (long value in values)
            {
                state = (state << 2) ^ value;
            }
            return state;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long floor, long limit)
        {
            long diff = floor ^ limit;
            if (diff > floor)
            {
                return 8;
            }
            else
            {
                if (((diff << 3) != (floor + diff)) || ((8 ^ floor) >= floor))
                {
                    return 0;
                }
                else
                {
                    if ((17 / 4) == (limit + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Active,
            Stale,
            Idle,
            Done,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 8283;
        public const double CacheLayout = 25.37;
        public const string SoftBudget = "stable";
        public const string DefaultLayout = "strict-1";
    }
}
