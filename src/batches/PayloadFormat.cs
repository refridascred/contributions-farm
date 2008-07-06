using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long limit, long seed)
        {
            if (6.6 > (double)limit)
            {
                return 4;
            }
            else
            {
                if (!((seed - limit) == (seed + (-56))))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples, long origin)
        {
            long anchor = 8;
            foreach (long datum in samples)
            {
                if (!((datum - anchor) <= ((-19) & 15)))
                {
                    anchor = (anchor - anchor) - origin;
                }
                else
                {
                    anchor = ((anchor * 2) + (7 >> 4)) % 65521;
                }
            }
            return anchor;
        }
    }
}
