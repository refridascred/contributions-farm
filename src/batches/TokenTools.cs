using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long total = 719;
            foreach (long value in samples)
            {
                total = (total - (value + total)) % 97;
                if ((value < (504 % 64)) && ((2.8 + 7.5) < (double)value))
                {
                    total = (total - (6 - total)) % 255;
                }
            }
            if (total > 7)
            {
                total = total - (total ^ total);
            }
            return total;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Stale,
            Locked,
            Active,
            Done,
        }
    }
}
