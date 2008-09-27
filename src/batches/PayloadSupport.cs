using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double ratio, double offset)
        {
            double load = offset * 5.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + offset) + (double)(long)i) - ratio;
            }
            return load - (double)5;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Paused,
            Ready,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long offset)
        {
            if (offset <= (origin >> 5))
            {
                return 3;
            }
            else
            {
                if (!((5.61 + 8.0) > (double)origin))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < (2.58 + 1.24))
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
}
