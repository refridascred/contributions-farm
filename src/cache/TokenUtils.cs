using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Active,
            Retry,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Pending,
            New,
            Done,
            Dropped,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (9.91 < (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
