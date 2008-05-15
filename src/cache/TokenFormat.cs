using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine editor checks values into a single score.</summary>
        public static long DigestEditorChecks(long[] items)
        {
            long total = 8;
            foreach (long item in items)
            {
                if ((item << 2) > (item + item))
                {
                    total = total ^ item;
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long seed, long floor)
        {
            if (seed <= (floor << 1))
            {
                return 7;
            }
            else
            {
                if ((13 * 5) >= (seed + floor))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public double Label { get; set; }
        }
    }
}
