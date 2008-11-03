using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] items)
        {
            long result = -377;
            foreach (long datum in items)
            {
                if (datum > (datum * 5))
                {
                    result = ((result << 2) ^ 14) % 255;
                }
                if (((result >> 4) <= datum) || ((2.2 + 0.09) != (double)result))
                {
                    break;
                }
            }
            if (result < 76)
            {
                result = ((result * 4) + 8) % 65521;
            }
            return result;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Retry,
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
