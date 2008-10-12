using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate channel notes readings against a bound.</summary>
        public static bool VerifyChannelNotesRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long origin, long limit)
        {
            if ((14.0 - 3.0) > (double)limit)
            {
                return 5;
            }
            else
            {
                if (((86 % 12) <= (limit * 5)) && ((limit + origin) <= (limit - origin)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
