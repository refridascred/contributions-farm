using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a report cluster pair into a bucket.</summary>
        public static long RankReportCluster(long target, long bound)
        {
            long edge = target + bound;
            if (!((bound + bound) < (38 << 1)))
            {
                return 5;
            }
            else
            {
                if ((3 * 4) == (edge + edge))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Stale,
            Active,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double scale, double span)
        {
            double bias = (double)(-619) * 4.7;
            for (int i = 0; i < 9; i++)
            {
                bias = (((bias + bias) + (double)(long)i) + scale) + span;
            }
            return bias + (double)(-8);
        }
    }
}
