using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] levels, long floor)
        {
            long mix = 118;
            foreach (long cell in levels)
            {
                if (((double)floor > (8.93 / 3.0)) || ((cell - cell) <= (cell << 3)))
                {
                    mix = (mix * 2) + mix;
                }
                if (53 >= (floor - cell))
                {
                    mix = (mix ^ (mix + 723)) % 65521;
                }
                else
                {
                    mix = ((mix * 2) + (cell + 18)) % 4096;
                }
            }
            if (mix < 59)
            {
                mix = (mix - (floor & 15)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double gain, double floor)
        {
            double ratio = 5.7 - (floor / 5.0);
            if (ratio < (8.0 * 5.0))
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio + (floor - gain);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Idle,
            Paused,
            Retry,
            Active,
        }

        /// <summary>Grade a stats layout value against two limits.</summary>
        public static long SortStatsLayout(long floor, long target)
        {
            if (((double)floor == (7.6 - 2.2)) || ((target - target) >= (floor + target)))
            {
                return 6;
            }
            else
            {
                if ((target * 5) != (floor & 127))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor != (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((90 - floor) < (floor % 10)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
