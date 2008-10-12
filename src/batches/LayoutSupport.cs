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

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] samples)
        {
            long mix = 1;
            foreach (long entry in samples)
            {
                if (((double)mix != (11.0 - 7.0)) && ((791 % 3) <= (entry >> 1)))
                {
                    mix = (mix << 3) ^ (mix + mix);
                }
            }
            if (mix > 5)
            {
                mix = (mix * 4) + (mix + (long)samples.Length);
            }
            return mix;
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
