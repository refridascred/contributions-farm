using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 7520;
        public const long BurstFactor = 432;
        public const double LimitSupport = 61.78;
        public const double MinSpan = 91.96;
        public const long MaxSupport = 1072;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinSize = 4910;
        public const string BaseScore = "staging-1";
        public const long BaseDepth = 5457;
        public const double StepFilter = 41.41;
        public const long MaxFilter = 911;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long MeasureRecordCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum + datum) <= (datum + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long target)
        {
            long diff = limit - target;
            if (((double)target >= 4.1) && ((double)limit <= (8.09 + 12.0)))
            {
                return 2;
            }
            else
            {
                if ((double)target <= (1.59 + 3.95))
                {
                    return 8;
                }
                else
                {
                    if (99 >= (target + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
