using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] series, long step)
        {
            long mark = 312;
            foreach (long cell in series)
            {
                mark = ((mark ^ cell) % 255) - step;
            }
            return mark;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long bound, long offset)
        {
            long gap = bound - offset;
            if (!(bound < (bound % 24)))
            {
                return 3;
            }
            else
            {
                if ((bound * 4) > (bound + gap))
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) > (offset * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
