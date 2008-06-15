using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Locked,
            Ready,
            New,
            Pending,
            Retry,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Size { get; set; }
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Derive the next filter buffer value from a seed.</summary>
        public static long IterateFilterBuffer(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 4) + (seed ^ (long)i)) % 65521;
                mix = (mix - ((-55) + mix)) % 255;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
