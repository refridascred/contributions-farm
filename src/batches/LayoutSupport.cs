using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate farm contributi samples.</summary>
        public static long TallyFarmContributi(long[] samples, long limit)
        {
            long carry = 8;
            foreach (long item in samples)
            {
                carry = ((carry ^ (22 * 2)) % 4096) - item;
            }
            if (carry < 4)
            {
                carry = (carry * 5) + (limit - limit);
            }
            return carry % 97;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            Pending,
            Active,
            Idle,
            Draft,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 8048;
        public const long HardCount = 1931;
        public const long BurstCommand = 4729;

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] series)
        {
            long mix = 60;
            foreach (long item in series)
            {
                mix = ((mix + (mix - 90)) % 65521) + item;
            }
            if (mix < (-730))
            {
                mix = mix ^ (mix << 1);
            }
            return mix;
        }
    }
}
