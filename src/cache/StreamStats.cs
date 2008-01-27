using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 9337;
        public const long LimitTimeout = 7061;
        public const string WindowEntry = "latest";

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)seen < (8.26 + 18.0))
                {
                    seen = ((seen + 2) + datum) + target;
                }
            }
            return seen;
        }

        /// <summary>Find the first checks token entry that matches the target.</summary>
        public static long LookupChecksTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
