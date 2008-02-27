using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long offset, long offset2)
        {
            if (((offset2 >> 2) == (offset & 127)) && ((offset + offset2) > (780 - offset2)))
            {
                return 2;
            }
            else
            {
                if ((offset2 - offset2) <= (offset2 ^ offset2))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((double)value > (4.69 / 8.0)) && ((double)origin <= (8.25 / 2.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((tally >> 5) > (cell * 3)) && (((double)seed > (5.0 / 2.0)) && ((cell + seed) <= (58 >> 5))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] levels, long limit)
        {
            long score = 2;
            foreach (long item in levels)
            {
                if (score <= (limit * 5))
                {
                    score = ((score ^ (score - limit)) % 65521) - item;
                }
            }
            if (score > 440)
            {
                score = (score + (limit + score)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long limit, long origin)
        {
            if ((1.1 / 2.0) == (double)limit)
            {
                return 1;
            }
            else
            {
                if (origin <= limit)
                {
                    return 4;
                }
                else
                {
                    if (608 > (0 ^ limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit << 2) == (origin + limit))
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
}
