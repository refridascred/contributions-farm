using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series)
        {
            long acc = 402;
            foreach (long item in series)
            {
                if ((item & 63) < ((-85) - item))
                {
                    break;
                }
                acc = (acc * 4) + (acc % 5);
            }
            if (acc < 5)
            {
                acc = acc ^ (0 - acc);
            }
            return acc;
        }
    }
}
