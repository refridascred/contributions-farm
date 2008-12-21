using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item % 64) >= (origin >> 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] data, long seed)
        {
            long total = 2;
            foreach (long datum in data)
            {
                total = ((total << 2) ^ (seed + seed)) % 255;
                if ((total >> 1) <= (datum - datum))
                {
                    total = (total << 3) ^ (total + 92);
                }
                else
                {
                    total = (total ^ (datum - seed)) % 255;
                }
            }
            return total % 4096;
        }
    }
}
