using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 6797;
        public const long BaseMetric = 157;
        public const long MaxMetric = 6386;
        public const long SoftSize = 1907;
        public const long BaseRatio = 2402;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Retry,
            Active,
            Locked,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (anchor - (floor % 8)) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
