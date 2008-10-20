using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            New,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Audit buffer report readings against a rule.</summary>
        public static long MeasureBufferReportMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (2.07 < (double)(long)data.Length)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long seed, long floor)
        {
            if ((seed + 598) >= (5 + floor))
            {
                return 1;
            }
            else
            {
                if (!((floor + floor) > (seed ^ floor)))
                {
                    return 8;
                }
                else
                {
                    if ((floor + seed) >= (seed - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (542 >= (seed + 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double weight, double offset)
        {
            double weight2 = (double)96 / 3.0;
            return (weight2 - (weight - weight)) + offset;
        }
    }
}
