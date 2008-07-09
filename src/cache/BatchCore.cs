using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of account cluster readings.</summary>
        public static long CombineAccountCluster(long[] data)
        {
            long score = 91;
            foreach (long cell in data)
            {
                score = ((score ^ (2 - score)) % 65521) + cell;
            }
            return score;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long offset, long seed)
        {
            if (((double)offset < (3.3 / 5.0)) && (69 < seed))
            {
                return 4;
            }
            else
            {
                if ((double)offset > (3.39 / 2.0))
                {
                    return 8;
                }
                else
                {
                    if ((offset + (-7)) > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset <= (9.0 - 3.46))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultRatio = "stable";
        public const long RetryEntry = 7719;
        public const long IdleEntry = 5761;
        public const long SoftEntry = 1525;
    }
}
