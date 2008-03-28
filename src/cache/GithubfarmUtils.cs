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

        /// <summary>Classify a account graph pair into a bucket.</summary>
        public static long BucketAccountGraph(long target, long bound)
        {
            if ((bound * 3) >= target)
            {
                return 4;
            }
            else
            {
                if ((double)target > 2.05)
                {
                    return 5;
                }
                else
                {
                    if (((bound + target) != (target - bound)) || ((7.0 + 7.0) == (double)bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
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
