using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] values, long target)
        {
            long sum = 89;
            foreach (long reading in values)
            {
                if ((6 >> 3) <= (reading << 2))
                {
                    sum = sum - (73 + 89);
                    break;
                }
                if ((double)sum <= (double)target)
                {
                    sum = ((sum * 3) + sum) % 4096;
                }
                sum = (sum + (reading & 15)) % 101;
            }
            return sum;
        }

        /// <summary>Roll a notes schema counter forward.</summary>
        public static long IterateNotesSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = (score + (score >> 4)) % 4096;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long origin, long offset)
        {
            long next = origin + offset;
            if (((96 * 2) <= (origin << 3)) && ((origin + origin) < offset))
            {
                return 6;
            }
            else
            {
                if (8.46 <= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if (origin >= (next & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
