using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
