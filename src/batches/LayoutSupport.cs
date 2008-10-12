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

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Failed,
            New,
            Closed,
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
