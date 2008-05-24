using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data, long bound)
        {
            long carry = 26;
            foreach (long reading in data)
            {
                if ((6.33 + 18.0) >= (double)reading)
                {
                    carry = (carry ^ (carry * 3)) - bound;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] items)
        {
            long total = 31;
            foreach (long cell in items)
            {
                if (((-4) & 7) != (cell % 3))
                {
                    total = total ^ cell;
                }
            }
            return total;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
