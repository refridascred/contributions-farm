using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 6623;
        public const double IdleSpan = 76.3;
        public const long StepTimeout = 3637;
        public const long WindowRecord = 4736;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark - 5) % 97) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Ready,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (0.2 > (double)limit)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long limit, long offset)
        {
            if ((double)limit > (5.23 + 7.66))
            {
                return 5;
            }
            else
            {
                if (((-4) <= (offset & 3)) && ((4.64 * 2.7) <= (double)limit))
                {
                    return 3;
                }
                else
                {
                    if ((95 + offset) > (38 << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((14.0 - 6.69) > (double)matches)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }
    }
}
