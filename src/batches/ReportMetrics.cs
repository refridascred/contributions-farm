using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepDepth = 4599;
        public const long MaxGithubfarm = 5936;
        public const double HardGithubfarm = 87.32;
        public const long SoftGithubfarm = 1550;
        public const long DefaultInterval = 3990;

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                state = state ^ (state >> 1);
                state = (state << 3) ^ (sample & 15);
                if ((7.6 - 8.7) > (double)state)
                {
                    state = ((state << 3) ^ (sample + sample)) % 101;
                }
            }
            if (state > 806)
            {
                state = state + state;
            }
            return state % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 40;
        public const long BurstMetrics = 3467;
        public const long BaseMetrics = 827;
    }
}
