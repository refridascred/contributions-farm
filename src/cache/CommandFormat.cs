using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples, long target)
        {
            long sum = 7;
            foreach (long entry in samples)
            {
                if (70 > sum)
                {
                    sum = ((sum * 3) + (entry & 255)) % 4096;
                }
                sum = (sum - (target % 10)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinLevel = 1740;
        public const string MinEditor = "local";
        public const string HardEditor = "strict";
        public const long BaseEditor = 9490;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
