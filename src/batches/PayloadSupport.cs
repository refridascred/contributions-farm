using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a notes schema pair into a bucket.</summary>
        public static long BucketNotesSchema(long offset, long bound)
        {
            if ((5.2 + 4.6) <= (double)bound)
            {
                return 8;
            }
            else
            {
                if ((offset / 8) <= (81 / 5))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry < (4 % 16))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double ratio = (double)(217 >> 4);
            if (ratio <= rate)
            {
                ratio = ratio - 6.26;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio - (span / 2.0);
        }
    }
}
