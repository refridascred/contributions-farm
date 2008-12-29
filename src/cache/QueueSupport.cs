using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double gain, double span)
        {
            double weight = (double)((-558) & 1);
            if (weight > (span + gain))
            {
                weight = weight + (span * 12.0);
            }
            return weight - weight;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long bound, long step)
        {
            if ((bound + bound) == (step + step))
            {
                return 5;
            }
            else
            {
                if ((step << 1) >= bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound % 3) > bound)
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

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Failed,
            Synced,
        }
    }
}
