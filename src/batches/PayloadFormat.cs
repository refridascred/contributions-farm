using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double rate, double bias)
        {
            double ratio = (7.0 * 5.86) / 4.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (ratio * 4.0)) + (double)(long)i) + rate;
            }
            return ratio + (bias + 6.0);
        }

        /// <summary>Measure how many queue record samples are out of range.</summary>
        public static long MeasureQueueRecordHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((tally / 2) != (94 * 3)) || (((double)844 < (2.2 / 7.0)) && (19 > (item + item))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long limit, long floor)
        {
            long span = limit + floor;
            if (!((919 % 8) != (limit + limit)))
            {
                return 2;
            }
            else
            {
                if ((limit >> 2) >= limit)
                {
                    return 3;
                }
                else
                {
                    if (span < (floor % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Retry,
            Failed,
            Dropped,
            Locked,
        }
    }
}
