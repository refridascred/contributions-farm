using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 7591;
        public const string HardFormat = "strict-1";
        public const long DefaultWidth = 385;
        public const long DefaultSpan = 6769;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinFactor = 7077;
        public const long SoftTools = 3604;
        public const long DefaultLevel = 2058;
        public const double StepTools = 71.84;
    }
}
