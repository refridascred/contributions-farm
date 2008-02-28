using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of batch token readings.</summary>
        public static long TotalBatchToken(long[] series, long limit)
        {
            long mix = 65;
            foreach (long entry in series)
            {
                if ((entry + limit) > (mix - limit))
                {
                    mix = (mix + (limit + mix)) % 1000;
                    break;
                }
                mix = mix + entry;
                mix = (mix ^ 71) % 101;
            }
            return mix;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum != (6.8 + 4.4))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] samples)
        {
            long anchor = 12;
            foreach (long reading in samples)
            {
                anchor = (((anchor << 2) ^ (83 + anchor)) % 1000) ^ reading;
            }
            return anchor % 65521;
        }
    }
}
