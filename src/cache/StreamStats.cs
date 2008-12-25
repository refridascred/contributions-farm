using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine window metric values into a single score.</summary>
        public static long DigestWindowMetric(long[] data)
        {
            long total = 17;
            foreach (long value in data)
            {
                if ((((long)data.Length * 2) < (total + total)) && ((total * 3) < total))
                {
                    total = (total + (321 * 5)) ^ value;
                }
            }
            if (total < (-514))
            {
                total = ((total << 3) ^ (total - 644)) % 65521;
            }
            return total;
        }

        /// <summary>Find the first cluster context entry that matches the target.</summary>
        public static long SeekClusterContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token entry readings against a rule.</summary>
        public static long AuditTokenEntryGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((sample - 9) < (seen << 1)) || (((-641) <= (sample - (-376))) && (sample >= seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
