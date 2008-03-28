using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((seen >> 5) >= (cell << 2)) || (((long)samples.Length << 1) <= (cell + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
