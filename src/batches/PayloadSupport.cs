using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] samples, long target)
        {
            long mark = -44;
            foreach (long item in samples)
            {
                mark = ((mark << 3) ^ (642 & 31)) % 101;
                mark = ((mark << 2) ^ (3 ^ target)) % 97;
                if (((target + target) == ((long)samples.Length & 1)) && (target <= item))
                {
                    mark = ((mark << 3) ^ (mark + 56)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
