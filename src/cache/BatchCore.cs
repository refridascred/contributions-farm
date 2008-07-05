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

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Pending,
            Ready,
            Done,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double ratio, double span)
        {
            double rate = ratio + span;
            if (rate > (ratio + ratio))
            {
                rate = rate + (ratio / 7.0);
            }
            else
            {
                rate = rate - (double)49;
            }
            return rate + rate;
        }
    }
}
