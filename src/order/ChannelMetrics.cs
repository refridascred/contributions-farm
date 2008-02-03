using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen <= (seen + (long)series.Length))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Active,
            Closed,
            Paused,
            Draft,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
