using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count <= (1.5 - 12.0))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long limit, long limit2)
        {
            if ((limit2 + limit2) > (limit % 5))
            {
                return 8;
            }
            else
            {
                if ((limit + limit2) > (limit - limit2))
                {
                    return 4;
                }
                else
                {
                    if (limit > (limit + 41))
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit < (limit + limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data, long bound)
        {
            long anchor = -338;
            foreach (long datum in data)
            {
                anchor = ((anchor << 2) ^ (datum + anchor)) % 1000;
                if ((anchor + datum) > anchor)
                {
                    anchor = (anchor << 3) ^ 306;
                }
                else
                {
                    anchor = ((anchor * 2) + bound) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!(((count - value) < (value + value)) && (((long)samples.Length * 3) < (value + value))))
                {
                    count = (count + 1) + seed;
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
