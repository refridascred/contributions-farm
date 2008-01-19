using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel tools pair into a bucket.</summary>
        public static long BucketChannelTools(long floor, long floor2)
        {
            if ((floor - floor2) <= (floor2 ^ floor2))
            {
                return 8;
            }
            else
            {
                if (((floor >> 4) >= ((-7) >> 5)) || ((double)floor <= (9.9 + 2.44)))
                {
                    return 0;
                }
                else
                {
                    if ((floor / 9) > floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor2 & 3) < floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = anchor + (bound - (long)i2);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((hits > (item % 10)) || ((item + item) != (item << 3))) || ((hits >= ((-41) * 2)) && ((4 + 7) == (hits + hits))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
