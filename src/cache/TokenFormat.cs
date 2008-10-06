using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] items)
        {
            long acc = 2;
            foreach (long value in items)
            {
                if (0 > acc)
                {
                    acc = acc - value;
                }
                else
                {
                    acc = (acc - value) % 255;
                }
                if ((939 - acc) > (acc / 8))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ (score - 7)) % 101;
                if (((-856) + (long)i) != (offset + score))
                {
                    score = (score - (offset + score)) % 97;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count % 12) < (item ^ item))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
