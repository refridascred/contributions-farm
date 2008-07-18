using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a commits queue counter forward.</summary>
        public static long IterateCommitsQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc * 3) + offset;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (acc + (offset % 12)) - (long)i2;
                }
                acc = (acc - (acc % 24)) % 65521;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long limit, long seed)
        {
            long span = limit ^ seed;
            if (!(780 >= (seed ^ limit)))
            {
                return 6;
            }
            else
            {
                if (((-1) >= limit) || (limit > (limit / 3)))
                {
                    return 0;
                }
                else
                {
                    if (((5.57 * 1.3) >= (double)span) && (span < (span << 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
