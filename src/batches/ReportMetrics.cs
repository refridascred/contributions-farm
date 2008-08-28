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

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] readings, long limit)
        {
            long mix = 4;
            foreach (long cell in readings)
            {
                if (!(6 < (limit + cell)))
                {
                    mix = mix - (mix << 3);
                }
                else
                {
                    mix = mix ^ (mix << 3);
                }
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
