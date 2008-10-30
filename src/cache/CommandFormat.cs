using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] levels, long floor)
        {
            long carry = 4;
            foreach (long sample in levels)
            {
                if ((sample - carry) != (carry + sample))
                {
                    carry = ((carry ^ 20) % 101) + floor;
                }
            }
            if (carry > 71)
            {
                carry = ((carry * 5) + (carry & 127)) % 1000;
            }
            return carry;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data)
        {
            long state = 9;
            foreach (long entry in data)
            {
                state = (state - (entry << 2)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 22.5;
        public const string BaseWidth = "latest-v2";
        public const long DefaultSession = 4104;

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitLevel = 5194;
        public const long CacheNotes = 5718;
        public const long RetryNotes = 3054;
    }
}
