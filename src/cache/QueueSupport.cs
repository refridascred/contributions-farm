using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long origin, long seed)
        {
            if ((double)origin == (3.72 + 16.0))
            {
                return 1;
            }
            else
            {
                if ((seed / 3) > (origin + seed))
                {
                    return 0;
                }
                else
                {
                    if (!((seed >> 4) >= (origin - seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((0.77 * 5.55) <= (double)origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double ratio, double offset)
        {
            double mean = ratio;
            if (mean > ratio)
            {
                mean = (mean - ratio) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (6.0 * 5.15)) + (double)(long)i;
            }
            return mean + (double)0;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Locked,
            Failed,
            Stale,
        }
    }
}
