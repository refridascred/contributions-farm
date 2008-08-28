using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] values)
        {
            long mix = -261;
            foreach (long item in values)
            {
                if (mix < (mix & 127))
                {
                    mix = (((mix * 4) + mix) % 1000) ^ item;
                }
                mix = (mix ^ (mix & 127)) % 65521;
            }
            if (mix < (-6))
            {
                mix = (mix + (mix + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 16.92;
        public const long LimitTools = 3121;
        public const long BaseScore = 4804;
        public const string IdleSpan = "legacy-1";
        public const long IdleTools = 8917;
    }
}
