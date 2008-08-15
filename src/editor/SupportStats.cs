using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string IdleSize = "open-1";
        public const double StepBudget = 10.06;
        public const string BurstInterval = "strict-v2";
        public const long SoftToken = 8860;

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCount = 2937;
        public const long BaseCommits = 3024;
        public const long IdleCommits = 5282;

        /// <summary>Count the buffer record entries that pass the check.</summary>
        public static long CountBufferRecordOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((1.85 - 7.3) <= (double)reading)
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }
    }
}
