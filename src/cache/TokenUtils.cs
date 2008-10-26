using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "alpha-v2";
        public const long IdleInterval = 7998;
        public const long MaxProfile = 5424;

        /// <summary>Measure how many record profile samples are out of range.</summary>
        public static long TallyRecordProfileOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((((718 - sample) > (sample >> 4)) && ((7.67 + 17.0) != (double)bound)) || !(sample < (sample + 204)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
