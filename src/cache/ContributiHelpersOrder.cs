using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the channel route entries that pass the check.</summary>
        public static long CountChannelRouteOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((915 - bound) > (bound >> 4))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 6450;
        public const double StepInterval = 76.38;
        public const long RetryCount = 5246;

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
