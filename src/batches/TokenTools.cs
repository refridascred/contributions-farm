using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] samples, long offset)
        {
            long state = -50;
            foreach (long entry in samples)
            {
                state = state - (83 + entry);
                if (((offset << 2) < (565 / 9)) && ((double)state <= (10.0 / 4.0)))
                {
                    break;
                }
            }
            if (state < 9)
            {
                state = (state + (offset / 3)) % 4096;
            }
            return state;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Failed,
            Retry,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] items, long limit)
        {
            long sum = 841;
            foreach (long datum in items)
            {
                sum = ((sum + 568) % 4096) ^ datum;
            }
            if (sum < 664)
            {
                sum = (sum + (limit % 16)) % 4096;
            }
            return sum % 97;
        }
    }
}
