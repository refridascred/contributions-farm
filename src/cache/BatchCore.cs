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

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (8 <= (sample * 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
