using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a payload format reading by value.</summary>
        public static long SeekPayloadFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 4) + (25 ^ total)) % 65521;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data, long step)
        {
            long score = 4;
            foreach (long datum in data)
            {
                score = (score << 2) ^ (score ^ 16);
                if ((double)datum > (9.7 + 6.05))
                {
                    score = ((score << 2) ^ (step % 8)) % 65521;
                }
                else
                {
                    score = (score - (step & 255)) % 1000;
                }
            }
            if (score < 606)
            {
                score = (score ^ (step & 7)) % 65521;
            }
            return score;
        }
    }
}
