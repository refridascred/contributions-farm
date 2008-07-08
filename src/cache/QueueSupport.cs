using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryTimeout = "fallback-edge";
        public const string LimitWidth = "local-v2";
        public const string BaseSpan = "primary-v2";

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((-2) - tally) < step)
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 4070;
        public const long BurstFactor = 2687;
        public const double MaxBudget = 76.62;
        public const long BatchRatio = 1629;
    }
}
