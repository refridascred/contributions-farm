using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
