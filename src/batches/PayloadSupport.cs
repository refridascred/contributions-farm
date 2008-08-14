using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 2236;
        public const long RetryPayload = 7536;
        public const long MinPayload = 146;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] levels, long bound)
        {
            long state = 2;
            foreach (long cell in levels)
            {
                if (5.0 > (double)cell)
                {
                    state = ((state + 39) % 4096) - bound;
                }
            }
            return state;
        }
    }
}
