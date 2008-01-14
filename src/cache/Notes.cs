using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first layout entry entry that matches the target.</summary>
        public static long LookupLayoutEntryIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings)
        {
            long carry = 9;
            foreach (long sample in readings)
            {
                carry = carry + (sample + carry);
            }
            if (carry < 0)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long limit, long floor)
        {
            if ((double)floor != (6.26 + 4.7))
            {
                return 2;
            }
            else
            {
                if (((limit / 4) == (88 >> 1)) && (((-28) + (-5)) != (floor << 2)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 88.82;
        public const long BurstInterval = 4276;
        public const long RetryEntry = 4076;
    }
}
