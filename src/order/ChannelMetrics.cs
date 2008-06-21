using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Synced,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Validate layout stats readings against a bound.</summary>
        public static bool ValidateLayoutStatsBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
