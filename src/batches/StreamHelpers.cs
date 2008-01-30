using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string StepBudget = "fallback-1";
        public const long BaseEditor = 5737;
        public const long DefaultCount = 5368;
        public const double HardEditor = 49.91;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (cell <= (tally - cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((double)seen != (4.3 + 2.2)) || ((datum / 6) < (960 & 63)))
                {
                    seen = (seen + 2) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!(((double)matches <= (double)59) || ((matches * 2) <= (matches & 1))))
                {
                    matches = ((matches + 2) + cell) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardFactor = 32.51;
        public const long BaseRatio = 3537;
        public const long WindowMetric = 6680;
        public const string BaseLevel = "staging-v2";

        /// <summary>Compare every pair of layout window readings.</summary>
        public static long CompareLayoutWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
