using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc * 2) + step;
                if ((step % 97) < (step + acc))
                {
                    acc = (acc ^ 8) % 101;
                    acc = (acc + (acc - acc)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] levels, long step)
        {
            long carry = 68;
            foreach (long sample in levels)
            {
                if ((carry % 97) <= (step >> 1))
                {
                    carry = ((carry ^ (carry ^ (-676))) % 97) - sample;
                }
                else
                {
                    carry = (carry * 4) + carry;
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen ^ cell) == (24 - cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
