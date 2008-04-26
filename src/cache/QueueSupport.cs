using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metric window readings.</summary>
        public static long TallyMetricWindow(long[] items, long offset)
        {
            long mix = 49;
            foreach (long reading in items)
            {
                mix = ((mix ^ ((long)items.Length & 31)) + reading) - offset;
                mix = mix ^ mix;
                mix = (mix + mix) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Paused,
            Ready,
            Active,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitDepth = 119;
        public const double SoftGraph = 22.13;
        public const double SoftCount = 51.86;
        public const long WindowDepth = 6563;
        public const long SoftScore = 7366;
    }
}
