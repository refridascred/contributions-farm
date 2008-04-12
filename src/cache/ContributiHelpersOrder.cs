using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long offset, long target)
        {
            if ((double)offset < (9.84 - 13.0))
            {
                return 5;
            }
            else
            {
                if (offset > (target & 7))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 6064;
        public const string HardInterval = "latest-edge";
        public const long RetryFilter = 9861;
        public const long BaseWidth = 9084;
        public const long MinFilter = 4494;

        /// <summary>Define support limits and defaults.</summary>
        public const long StepFactor = 2857;
        public const string RetrySupport = "strict-v2";
        public const double DefaultSupport = 34.89;
        public const string MinSupport = "stable-v2";
        public const long HardLevel = 2176;
    }
}
