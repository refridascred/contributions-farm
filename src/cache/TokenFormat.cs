using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels)
        {
            long result = -8;
            foreach (long value in levels)
            {
                result = ((result << 3) ^ (8 % 5)) % 65521;
                result = result - result;
                if ((0 * 3) <= value)
                {
                    result = result - (84 - result);
                }
                else
                {
                    result = (result << 2) ^ (value + 425);
                }
            }
            return result;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public double Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
