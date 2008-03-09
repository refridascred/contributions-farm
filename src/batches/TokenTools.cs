using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Derive the next format layout value from a seed.</summary>
        public static long DeriveFormatLayout(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of context editor readings.</summary>
        public static long CompareContextEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
