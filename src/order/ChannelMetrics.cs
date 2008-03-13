using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] items)
        {
            long total = 658;
            foreach (long sample in items)
            {
                total = ((total << 3) ^ (total + total)) ^ sample;
            }
            return total % 97;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((sample + sample) < (sample << 2)) || ((sample - floor) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Synced,
            Draft,
            Pending,
            New,
            Retry,
        }
    }
}
