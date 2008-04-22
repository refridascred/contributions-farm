using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long bound, long offset)
        {
            if (((bound - offset) == (bound << 3)) && ((bound ^ 1) != (bound + bound)))
            {
                return 7;
            }
            else
            {
                if ((18.0 - 5.5) != (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 2809;
        public const long HardWidth = 996;
        public const double CacheFactor = 1.0;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }
    }
}
