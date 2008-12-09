using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long target, long floor)
        {
            if ((target + floor) >= ((-1) / 2))
            {
                return 3;
            }
            else
            {
                if (!((579 + 10) <= (target & 255)))
                {
                    return 6;
                }
                else
                {
                    if ((4.41 - 7.32) >= (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Queued,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double gain, double bias)
        {
            double bias2 = (double)9 / 7.0;
            if (bias2 < 2.1)
            {
                bias2 = ((bias2 + 11.0) + gain) + bias;
            }
            return bias2 + (double)711;
        }
    }
}
