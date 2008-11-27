using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] values)
        {
            long acc = 938;
            foreach (long datum in values)
            {
                if (((333 & 7) < datum) && (datum < acc))
                {
                    acc = (acc * 2) + (datum - datum);
                }
            }
            if (acc < 67)
            {
                acc = acc - (acc ^ acc);
            }
            return acc % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 4332;
        public const long BurstBudget = 9061;
        public const long BatchAccount = 2203;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value + hits) < value)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepFactor = 16.89;
        public const long DefaultScore = 7911;
        public const double IdlePayload = 40.16;
        public const long WindowLevel = 9243;
        public const string BasePayload = "legacy-1";
    }
}
