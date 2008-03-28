using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long seed, long origin)
        {
            if (216 <= (origin << 1))
            {
                return 6;
            }
            else
            {
                if ((85 & 127) >= origin)
                {
                    return 3;
                }
                else
                {
                    if ((seed + 46) == (origin * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin >= (seed % 97)) && ((double)origin < (12.0 - 2.62)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank batch contributi input into a small class.</summary>
        public static long GradeBatchContributi(long limit, long seed)
        {
            if (limit < (seed >> 5))
            {
                return 4;
            }
            else
            {
                if (seed < (5 * 3))
                {
                    return 7;
                }
                else
                {
                    if (((6.05 / 4.0) != (double)limit) || ((double)seed != (6.16 * 4.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell < (8.93 / 4.0))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
