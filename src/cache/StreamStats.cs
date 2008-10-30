using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Synced,
            Stale,
            New,
            Ready,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((8.88 - 1.94) == (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
