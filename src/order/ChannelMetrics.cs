using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double weight, double span)
        {
            double bias = (16.0 / 8.0) * 7.18;
            return ((bias - (double)89) + weight) + span;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long target, long origin)
        {
            long edge = target + origin;
            if (!((edge + target) >= (origin >> 2)))
            {
                return 5;
            }
            else
            {
                if ((origin / 8) < origin)
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < 8.0)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin <= edge) && ((double)origin == (8.0 * 5.75)))
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
}
