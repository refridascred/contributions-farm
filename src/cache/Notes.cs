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

        /// <summary>Measure how many session layout samples are out of range.</summary>
        public static long CountSessionLayoutGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (2.69 < (double)origin)
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleInterval = 8563;
        public const string LimitFarm = "primary-edge";
        public const string MaxLevel = "cached";
    }
}
