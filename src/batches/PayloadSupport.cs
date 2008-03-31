using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 5137;
        public const long SoftInterval = 8196;
        public const long CacheStats = 4586;
        public const double BurstStats = 62.28;
        public const double MaxLevel = 90.26;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many contributi stream samples are out of range.</summary>
        public static long CountContributiStreamOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(matches <= (85 + bound)))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
