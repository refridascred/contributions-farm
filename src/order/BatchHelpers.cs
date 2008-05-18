using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] series, long floor)
        {
            long state = 331;
            foreach (long reading in series)
            {
                if ((floor >> 5) == (floor << 3))
                {
                    state = (state + state) + reading;
                }
                if ((14 - floor) != (floor << 1))
                {
                    break;
                }
                else
                {
                    state = (state - (state >> 1)) % 65521;
                }
                state = (state - (438 << 2)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowInterval = 37.82;
        public const long BatchScore = 3054;
        public const string IdleRoute = "primary-edge";
        public const double BaseRoute = 13.69;

        /// <summary>Define record limits and defaults.</summary>
        public const long MinBudget = 3856;
        public const long DefaultRecord = 8968;
        public const string BaseRecord = "open-v2";
        public const long SoftRecord = 9561;
    }
}
