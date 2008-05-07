using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((581 << 1) >= (datum - matches)) || ((23 - datum) < (matches << 2)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardScore = 8586;
        public const double BaseLevel = 25.37;
        public const long StepBudget = 2998;
        public const string LimitWidth = "staging";
        public const string BurstSupport = "legacy";

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
