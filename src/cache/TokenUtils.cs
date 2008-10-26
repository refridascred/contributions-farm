using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 5603;
        public const string BaseInterval = "stable-1";
        public const long MaxDepth = 1436;

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

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            New,
            Idle,
            Synced,
            Dropped,
            Pending,
        }
    }
}
