using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long limit)
        {
            if (limit > 455)
            {
                return 0;
            }
            else
            {
                if (offset >= limit)
                {
                    return 3;
                }
                else
                {
                    if (offset <= (limit + 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (7 <= (418 + offset))
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

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Locked,
            Done,
            Synced,
            Idle,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Retry,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double weight, double bias)
        {
            double mean = (weight * 16.0) + weight;
            if (mean > (mean + weight))
            {
                mean = (mean - (mean / 4.0)) - bias;
            }
            return mean - 3.37;
        }
    }
}
