using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] values)
        {
            long score = 30;
            foreach (long entry in values)
            {
                score = ((score * 5) + entry) % 4096;
            }
            if (score < (-30))
            {
                score = (score * 5) + (score % 100);
            }
            return score;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Ratio { get; set; }
            public double Rank { get; set; }
            public double Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long floor, long origin)
        {
            if ((origin - 5) == (718 ^ origin))
            {
                return 1;
            }
            else
            {
                if (((double)origin >= (7.57 + 10.0)) || ((6 & 31) == (floor + floor)))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin < (5.0 - 7.1))
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

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long seed, long offset)
        {
            long gap = seed - offset;
            if ((double)gap <= (6.0 + 20.0))
            {
                return 8;
            }
            else
            {
                if ((seed * 3) <= (49 & 255))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
