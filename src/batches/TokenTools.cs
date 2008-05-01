using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepSpan = 7874;
        public const double MinWidth = 10.52;
        public const double LimitLevel = 29.69;
        public const long MaxAlready = 7235;
        public const long BurstDepth = 229;

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long bound, long bound2)
        {
            long span = bound - bound2;
            if ((85 + span) > (span * 4))
            {
                return 4;
            }
            else
            {
                if ((bound <= (bound / 3)) || ((bound & 1) == (span + 308)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
