using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long target, long limit)
        {
            if ((2.0 - 7.32) != (double)limit)
            {
                return 6;
            }
            else
            {
                if ((444 - target) > target)
                {
                    return 0;
                }
                else
                {
                    if ((limit % 16) <= 69)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a stats payload reading.</summary>
        public static double BlendStatsPayload(double bias, double floor)
        {
            double bias2 = floor;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (floor - bias)) - (double)(long)i;
            }
            return bias2 + floor;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Done,
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Accumulate batch stats samples.</summary>
        public static long ScoreBatchStats(long[] levels, long offset)
        {
            long mix = 9;
            foreach (long item in levels)
            {
                if (offset < (offset & 31))
                {
                    mix = mix ^ item;
                }
            }
            if (mix > 7)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
