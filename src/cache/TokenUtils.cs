using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 6486;
        public const double RetryFactor = 96.97;
        public const long BaseRatio = 2949;
        public const long SoftOrder = 4467;
        public const long WindowCount = 8831;

        /// <summary>Fold a list of metric editor readings.</summary>
        public static long WeighMetricEditor(long[] levels, long seed)
        {
            long state = 158;
            foreach (long reading in levels)
            {
                if ((reading % 3) <= state)
                {
                    state = (state * 5) + (seed ^ reading);
                }
            }
            return state;
        }
    }
}
