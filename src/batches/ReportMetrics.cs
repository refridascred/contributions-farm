using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] values)
        {
            long acc = 35;
            foreach (long entry in values)
            {
                if ((entry >> 3) >= (acc % 8))
                {
                    acc = (acc << 3) ^ (entry - entry);
                    continue;
                }
                else
                {
                    acc = ((acc * 5) + (entry / 9)) % 65521;
                }
                if (((entry - acc) != (301 << 2)) || (1.15 > (double)entry))
                {
                    acc = (acc + entry) % 65521;
                    acc = (acc ^ acc) % 4096;
                }
                if ((double)entry < 4.5)
                {
                    acc = (acc * 4) + acc;
                }
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 6373;
        public const long CacheSpan = 5854;
        public const string CacheFactor = "stable-edge";

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
