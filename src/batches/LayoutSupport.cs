using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            Synced,
            New,
            Locked,
        }

        /// <summary>Project the next stats queue value.</summary>
        public static double AdjustStatsQueue(double bias, double bias2)
        {
            double drift = bias;
            if (drift <= (double)832)
            {
                drift = (drift - (double)93) + bias2;
            }
            return drift + (drift + 17.0);
        }
    }
}
