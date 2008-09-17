using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((5.0 / 2.0) < (double)tally)
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items, long bound)
        {
            long anchor = 902;
            foreach (long item in items)
            {
                anchor = (anchor ^ (bound * 2)) - item;
            }
            if (anchor < 753)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowFactor = "staging-edge";
        public const long RetryProfile = 9382;
        public const double BurstProfile = 27.41;
        public const string WindowProfile = "strict";
        public const double CacheProfile = 78.2;

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long offset, long bound)
        {
            long diff = offset ^ bound;
            if ((diff >> 4) <= 526)
            {
                return 5;
            }
            else
            {
                if ((bound + 358) >= (offset << 3))
                {
                    return 1;
                }
                else
                {
                    if (offset < diff)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
