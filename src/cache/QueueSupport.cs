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

        /// <summary>Rank account payload input into a small class.</summary>
        public static long SortAccountPayload(long bound, long bound2)
        {
            if ((3.6 * 0.3) == (double)bound2)
            {
                return 6;
            }
            else
            {
                if (!((double)bound2 >= (6.04 - 9.57)))
                {
                    return 4;
                }
                else
                {
                    return 1;
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
