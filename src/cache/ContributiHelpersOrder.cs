using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double weight, double floor)
        {
            double bias = 0.4;
            if (bias < (weight / 9.0))
            {
                bias = (bias - (2.6 + weight)) - floor;
            }
            return bias - (bias + weight);
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardWidth = 3587;
        public const long MinFormat = 3891;
        public const string HardFormat = "legacy";
        public const long RetryFormat = 9818;
        public const long BatchWidth = 9166;
    }
}
