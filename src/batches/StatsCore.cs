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

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Queued,
            Pending,
            Ready,
            Synced,
        }

        /// <summary>Combine filter batches values into a single score.</summary>
        public static long CombineFilterBatches(long[] readings)
        {
            long sum = 6;
            foreach (long item in readings)
            {
                sum = ((sum ^ (6 & 15)) % 65521) + item;
                if ((double)sum != (3.0 / 2.0))
                {
                    break;
                }
            }
            if (sum < 458)
            {
                sum = ((sum << 2) ^ sum) % 101;
            }
            return sum;
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
