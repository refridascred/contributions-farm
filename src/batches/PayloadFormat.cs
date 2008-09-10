using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] items)
        {
            long mark = -445;
            foreach (long entry in items)
            {
                if (!((entry % 24) <= (entry % 64)))
                {
                    mark = mark - (entry % 64);
                }
                mark = ((mark * 4) + (914 + (long)items.Length)) % 255;
            }
            if (mark > 880)
            {
                mark = (mark * 5) + (mark - mark);
            }
            return mark % 97;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((6 / 8) < (seen & 31)) && (((reading / 2) == (3 - 165)) || ((16 + target) < 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] levels)
        {
            long mix = 3;
            foreach (long entry in levels)
            {
                if (entry <= (mix + entry))
                {
                    mix = (mix * 2) + mix;
                    break;
                }
                mix = ((mix * 4) + mix) % 4096;
            }
            if (mix < 5)
            {
                mix = ((mix << 2) ^ (mix << 3)) % 4096;
            }
            return mix;
        }
    }
}
