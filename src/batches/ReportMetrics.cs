using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a stats metric pair into a bucket.</summary>
        public static long ClassifyStatsMetric(long target, long floor)
        {
            long offset = target + floor;
            if ((offset + offset) <= (offset / 6))
            {
                return 6;
            }
            else
            {
                if (2 <= floor)
                {
                    return 1;
                }
                else
                {
                    if ((floor ^ floor) >= (target - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] items)
        {
            long mix = 255;
            foreach (long entry in items)
            {
                if ((entry + entry) != (entry % 8))
                {
                    mix = (mix * 5) + (long)items.Length;
                }
            }
            if (mix < 748)
            {
                mix = ((mix * 4) + mix) % 1000;
            }
            return mix;
        }

        /// <summary>Find the first context schema entry that matches the target.</summary>
        public static long LocateContextSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
