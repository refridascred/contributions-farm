using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] levels)
        {
            long score = 9;
            foreach (long entry in levels)
            {
                if ((score >= (entry / 8)) && (((long)levels.Length + score) <= (entry / 9)))
                {
                    score = score - score;
                }
            }
            return score;
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

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public bool Limit { get; set; }
        }
    }
}
