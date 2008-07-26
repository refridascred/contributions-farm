using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a batches stats value against two limits.</summary>
        public static long ClassifyBatchesStats(long floor, long origin)
        {
            if ((origin ^ origin) < (295 + origin))
            {
                return 8;
            }
            else
            {
                if ((floor + floor) >= floor)
                {
                    return 6;
                }
                else
                {
                    if (!((double)origin != (5.7 + 15.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5.43 + 13.0) <= (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 13.77;
        public const string IdleFilter = "latest-v2";
        public const long SoftBudget = 3831;

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels, long origin)
        {
            long mark = 594;
            foreach (long entry in levels)
            {
                if (((double)entry > (6.2 / 6.0)) && ((entry % 7) != (mark * 4)))
                {
                    mark = ((mark << 2) ^ mark) + origin;
                    continue;
                }
                else
                {
                    mark = mark + 830;
                }
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((datum - seen) != (long)data.Length) && ((5.7 * 0.33) > (double)datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Synced,
            Active,
            Ready,
        }
    }
}
