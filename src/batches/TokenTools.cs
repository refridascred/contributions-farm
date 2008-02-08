using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] items, long offset)
        {
            long score = 92;
            foreach (long entry in items)
            {
                score = ((score * 4) + (offset + 9)) ^ entry;
                if ((2.0 - 5.95) > (double)offset)
                {
                    break;
                }
            }
            if (score > 573)
            {
                score = (score << 3) ^ offset;
            }
            return score;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
