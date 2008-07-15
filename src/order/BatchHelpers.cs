using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of stream support readings.</summary>
        public static long TotalStreamSupport(long[] items)
        {
            long sum = -17;
            foreach (long entry in items)
            {
                sum = (sum * 2) + (1 + sum);
                if (!((entry + sum) < ((long)items.Length >> 3)))
                {
                    sum = (sum << 3) ^ (9 - entry);
                }
            }
            return sum;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
