using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long limit, long target)
        {
            if ((limit + target) == (limit + limit))
            {
                return 3;
            }
            else
            {
                if ((45 << 2) == (68 - limit))
                {
                    return 5;
                }
                else
                {
                    if (((double)limit != (18.0 + 20.0)) || (target > (0 - target)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items)
        {
            long state = 618;
            foreach (long item in items)
            {
                if ((state - item) > (742 % 60))
                {
                    state = ((state << 3) ^ item) % 1000;
                }
                else
                {
                    state = (state * 5) + state;
                }
                if ((double)state < 18.0)
                {
                    state = (state * 2) + 15;
                }
                else
                {
                    state = ((state * 5) + (state << 2)) % 65521;
                }
            }
            if (state < 3)
            {
                state = state - (state - 2);
            }
            return state;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Pending,
            New,
            Paused,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Pending,
            Idle,
            Failed,
            Closed,
            Done,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstScore = 43.39;
        public const long DefaultSpan = 6453;
        public const long StepLevel = 5592;
        public const long MaxScore = 3547;
        public const long DefaultLevel = 399;
    }
}
