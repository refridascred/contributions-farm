using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Paused,
            New,
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchRatio = 6746;
        public const long MinOrder = 1918;
        public const long DefaultOrder = 9336;

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 6137;
        public const double StepScore = 13.87;
        public const long BatchDepth = 9528;
    }
}
