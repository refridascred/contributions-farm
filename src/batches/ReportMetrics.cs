using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 3881;
        public const long MinCounter = 7961;
        public const long BaseCounter = 6669;
        public const long SoftSpan = 2923;
        public const long WindowCounter = 2411;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long target, long seed)
        {
            long step = target + seed;
            if (!((target ^ seed) > (target % 12)))
            {
                return 3;
            }
            else
            {
                if ((step ^ 334) > (step * 5))
                {
                    return 4;
                }
                else
                {
                    if (((double)target < (8.94 - 12.0)) || ((double)step == (19.0 / 8.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
