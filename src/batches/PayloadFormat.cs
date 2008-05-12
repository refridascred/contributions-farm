using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((double)(long)i >= (1.93 + 2.0))
                {
                    mark = ((mark << 2) ^ (mark - mark)) % 255;
                }
                else
                {
                    mark = ((mark * 4) + seed) % 4096;
                    mark = mark ^ (seed << 1);
                }
                if ((4.2 + 6.0) >= (double)mark)
                {
                    mark = mark ^ (mark / 5);
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (((mark * 5) + seed) % 255) - (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a entry stats value against two limits.</summary>
        public static long ClassifyEntryStats(long origin, long limit)
        {
            long bound = origin + limit;
            if ((bound % 100) != (origin * 2))
            {
                return 8;
            }
            else
            {
                if ((8 & 3) < bound)
                {
                    return 3;
                }
                else
                {
                    if (((1.13 / 5.0) > (double)origin) && ((double)limit <= 20.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(bound <= (limit - origin)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            New,
            Retry,
            Draft,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(((29 % 64) < (matches + 2)) || ((matches & 3) <= matches)))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
