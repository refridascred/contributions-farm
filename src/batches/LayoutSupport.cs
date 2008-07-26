using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public bool Ratio { get; set; }
            public double Flag { get; set; }
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

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long seed, long target)
        {
            long next = seed - target;
            if (((double)target > (5.6 / 8.0)) && ((double)369 < (double)target))
            {
                return 2;
            }
            else
            {
                if ((double)next >= (5.18 * 6.55))
                {
                    return 4;
                }
                else
                {
                    if ((seed + next) < seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((next + target) < seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
