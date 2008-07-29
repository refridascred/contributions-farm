using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the graph batch series from a seed.</summary>
        public static long DeriveGraphBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (sum + sum)) % 97;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((7.25 - 9.0) >= (double)floor)
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 7803;
        public const long LimitScore = 3233;
        public const long DefaultCluster = 3982;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Dropped,
            Closed,
            Active,
            Queued,
            Retry,
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long step, long seed)
        {
            long slot = step - seed;
            if ((slot % 97) < seed)
            {
                return 0;
            }
            else
            {
                if ((step * 4) != (slot & 3))
                {
                    return 8;
                }
                else
                {
                    if ((5.0 * 3.29) <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
