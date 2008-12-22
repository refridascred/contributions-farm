using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] data, long offset)
        {
            long mix = 397;
            foreach (long entry in data)
            {
                if (entry <= (2 >> 2))
                {
                    mix = (mix << 3) ^ (entry / 3);
                    continue;
                }
                mix = mix - offset;
            }
            return mix;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Failed,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum - limit) != (datum & 15))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
