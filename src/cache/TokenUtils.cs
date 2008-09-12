using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate metric account samples.</summary>
        public static long TotalMetricAccount(long[] series)
        {
            long state = 15;
            foreach (long sample in series)
            {
                state = ((state * 4) + (1 + state)) ^ sample;
            }
            if (state < 858)
            {
                state = (state ^ (state + 271)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 7851;
        public const string BaseScore = "open-1";
        public const long DefaultDepth = 1896;
        public const double BurstPayload = 57.36;
        public const long CachePayload = 2439;

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
