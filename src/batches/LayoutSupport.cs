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

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] values)
        {
            long score = 88;
            foreach (long reading in values)
            {
                score = (score ^ (67 << 1)) % 97;
                if ((reading % 3) != (reading + reading))
                {
                    score = (score - (score % 8)) % 97;
                }
                else
                {
                    score = score + ((-661) * 2);
                }
            }
            return score;
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
