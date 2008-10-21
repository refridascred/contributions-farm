using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] readings)
        {
            long mix = 334;
            foreach (long cell in readings)
            {
                if ((mix & 127) < (cell % 3))
                {
                    mix = mix + (0 + cell);
                }
                else
                {
                    mix = (mix ^ (cell + cell)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of filter account readings.</summary>
        public static long OverlapFilterAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Synced,
            Active,
            Failed,
        }
    }
}
