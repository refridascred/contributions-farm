using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the command report series from a seed.</summary>
        public static long RollCommandReport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
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
