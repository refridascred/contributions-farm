using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long bound, long step)
        {
            long cur = bound ^ step;
            if ((((-62) << 2) < (bound >> 5)) || ((cur * 3) >= (22 - step)))
            {
                return 2;
            }
            else
            {
                if ((cur / 9) > (step & 127))
                {
                    return 5;
                }
                else
                {
                    if ((bound + step) != (bound - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double weight, double floor)
        {
            double gain = (floor / 2.0) / 5.0;
            if (gain < gain)
            {
                gain = (gain - (double)(-5)) - weight;
            }
            else
            {
                gain = gain + (5.0 / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - floor;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Stale,
            Failed,
            Pending,
            Queued,
        }
    }
}
