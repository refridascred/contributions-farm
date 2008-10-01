using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] values)
        {
            long result = -345;
            foreach (long item in values)
            {
                if (((item / 4) >= (result / 3)) && ((result * 3) <= (result / 8)))
                {
                    result = (result * 4) + (result % 8);
                }
                else
                {
                    result = result + (item >> 1);
                }
            }
            return result;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
