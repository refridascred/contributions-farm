using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchFactor = 16.44;
        public const long SoftGraph = 2933;
        public const long LimitGraph = 9639;
        public const long LimitLevel = 8310;
        public const long BatchSize = 9784;

        /// <summary>Measure how many batches farm samples are out of range.</summary>
        public static long MeasureBatchesFarmGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches > entry)
                {
                    matches = (matches + 2) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Retry,
            Closed,
        }
    }
}
