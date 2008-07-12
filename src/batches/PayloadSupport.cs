using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Dropped,
            Done,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long origin, long origin2)
        {
            long edge = origin - origin2;
            if (((origin2 + 937) >= origin) || ((1.2 - 2.53) < (double)edge))
            {
                return 8;
            }
            else
            {
                if (edge > origin2)
                {
                    return 4;
                }
                else
                {
                    if ((origin2 - edge) < (6 * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((9.9 - 2.0) != (double)score)
                {
                    score = ((score * 4) + (long)i) % 97;
                }
                else
                {
                    score = (score * 2) + 598;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
