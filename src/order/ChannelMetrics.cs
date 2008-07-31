using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] series)
        {
            long result = 5;
            foreach (long sample in series)
            {
                if (result > sample)
                {
                    result = (result + 5) % 65521;
                }
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxSpan = 8068;
        public const long RetryChecks = 5993;
        public const long BurstChecks = 4839;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (matches >= (matches / 9))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
