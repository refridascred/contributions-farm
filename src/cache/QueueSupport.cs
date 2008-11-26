using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 9357;
        public const double CacheGraph = 76.48;
        public const long BurstDepth = 2741;

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] readings, long limit)
        {
            long result = 592;
            foreach (long reading in readings)
            {
                if (((result - limit) >= result) && ((7 / 8) != (reading << 2)))
                {
                    result = (result + (90 << 2)) % 65521;
                }
                result = ((result * 5) + (limit - (-751))) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Draft,
            Synced,
            Dropped,
            Ready,
        }
    }
}
