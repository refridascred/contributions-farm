using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 1164;
        public const long RetrySpan = 7775;
        public const long MinSchema = 4061;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long offset, long target)
        {
            if ((target - offset) != (target - target))
            {
                return 6;
            }
            else
            {
                if ((target % 100) <= ((-789) + 957))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank already route input into a small class.</summary>
        public static long ClassifyAlreadyRoute(long origin, long origin2)
        {
            if (!(675 > (origin + origin2)))
            {
                return 2;
            }
            else
            {
                if (origin <= (30 * 2))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Draft,
            Ready,
            Queued,
            Synced,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Synced,
            Pending,
            Failed,
        }
    }
}
