using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftWidth = "standard-v2";
        public const long BurstLayout = 5674;
        public const double LimitLevel = 45.67;

        /// <summary>Define context limits and defaults.</summary>
        public const double StepFactor = 62.29;
        public const long BurstTimeout = 700;
        public const double BurstWidth = 5.76;
    }
}
