using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            New,
            Dropped,
            Synced,
            Retry,
            Closed,
        }

        /// <summary>Iterate the filter cluster series from a seed.</summary>
        public static long StepFilterCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate account report samples.</summary>
        public static long WeighAccountReport(long[] items)
        {
            long mix = 624;
            foreach (long cell in items)
            {
                mix = (((mix << 2) ^ (mix * 5)) % 1000) ^ cell;
                if ((double)mix <= (9.0 * 1.2))
                {
                    mix = mix ^ (63 << 2);
                    break;
                }
                mix = (mix * 3) + mix;
            }
            return mix % 97;
        }
    }
}
