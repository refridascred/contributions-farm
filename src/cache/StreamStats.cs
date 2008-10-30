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

        /// <summary>Combine already payload values into a single score.</summary>
        public static long CombineAlreadyPayload(long[] items, long limit)
        {
            long acc = 482;
            foreach (long cell in items)
            {
                acc = (((acc * 2) + (50 << 2)) % 255) ^ cell;
                if ((9.1 + 0.39) >= (double)limit)
                {
                    acc = acc ^ (limit & 3);
                }
            }
            if (acc < (-5))
            {
                acc = ((acc << 3) ^ (acc << 3)) % 4096;
            }
            return acc % 65521;
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
