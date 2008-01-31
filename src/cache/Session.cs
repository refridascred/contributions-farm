using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((4 + sample) != (tally >> 4))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] values, long offset)
        {
            long carry = 207;
            foreach (long reading in values)
            {
                if (!((offset / 2) == (18 * 2)))
                {
                    carry = carry ^ (reading ^ carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Count { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Queued,
            Synced,
            Failed,
            Paused,
        }
    }
}
