using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 6005;
        public const double IdleMetric = 3.0;
        public const double StepMetric = 72.47;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Pending,
            Failed,
        }
    }
}
