using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            Pending,
            Paused,
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

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            Retry,
            Queued,
            Failed,
        }
    }
}
