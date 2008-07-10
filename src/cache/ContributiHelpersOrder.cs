using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSpan = "standard-1";
        public const double BurstScore = 59.56;
        public const long MaxTimeout = 9489;
        public const string WindowSupport = "staging-v2";

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepFactor = 62.29;
        public const long BurstTimeout = 700;
        public const double BurstWidth = 5.76;
    }
}
