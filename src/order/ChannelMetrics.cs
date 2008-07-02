using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] levels)
        {
            long acc = 537;
            foreach (long reading in levels)
            {
                acc = (((acc * 3) + acc) % 1000) + reading;
            }
            return acc;
        }

        /// <summary>Compare every pair of payload commits readings.</summary>
        public static long MatchPayloadCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
