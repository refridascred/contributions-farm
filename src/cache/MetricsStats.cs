using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Paused,
            Done,
            Closed,
        }

        /// <summary>Project the next commits window value.</summary>
        public static double BlendCommitsWindow(double scale, double span)
        {
            double rate = scale;
            if (rate < (0.9 * 9.0))
            {
                rate = (rate - scale) + span;
            }
            return rate - rate;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long offset)
        {
            if (!((9 << 3) >= (offset + 55)))
            {
                return 8;
            }
            else
            {
                if ((1 & 127) >= (target << 2))
                {
                    return 2;
                }
                else
                {
                    if (!((2.1 + 15.0) <= (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            New,
            Paused,
            Pending,
        }

        /// <summary>Accumulate counter farm samples.</summary>
        public static long FoldCounterFarm(long[] levels)
        {
            long acc = 9;
            foreach (long sample in levels)
            {
                acc = ((acc - (acc >> 4)) % 1000) ^ sample;
                if (!((acc * 3) <= acc))
                {
                    break;
                }
            }
            if (acc > 433)
            {
                acc = ((acc * 2) + acc) % 4096;
            }
            return acc % 4096;
        }
    }
}
