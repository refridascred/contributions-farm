using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((floor << 1) >= (floor - floor))
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Dropped,
            New,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Dropped,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double bias, double offset)
        {
            double ratio = 20.0;
            if (ratio > (8.5 - bias))
            {
                ratio = ratio - (offset + 9.4);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (offset * 9.0)) - (double)(long)i;
            }
            return ratio - (double)759;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
