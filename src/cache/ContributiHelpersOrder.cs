using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 462;
        public const string MinFilter = "open";
        public const long LimitDepth = 4429;
        public const double SoftFactor = 13.36;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 2329;
        public const string MaxMetrics = "primary-1";
        public const long BatchBudget = 8546;
        public const long WindowMetrics = 2181;
        public const long IdleMetrics = 4273;

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
