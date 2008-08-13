using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long floor, long seed)
        {
            if ((floor / 8) >= (floor >> 1))
            {
                return 0;
            }
            else
            {
                if (((seed + seed) > (seed % 100)) || ((seed + seed) <= (seed - seed)))
                {
                    return 6;
                }
                else
                {
                    if ((7.0 < (double)floor) || (((-8) % 12) == (floor + floor)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8.35 - 2.21) > (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many support graph samples are out of range.</summary>
        public static long CountSupportGraphOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item - seen) == (seen * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine metric format values into a single score.</summary>
        public static long FoldMetricFormat(long[] items, long bound)
        {
            long acc = 28;
            foreach (long entry in items)
            {
                acc = ((acc * 5) + 7) ^ entry;
            }
            if (acc < 68)
            {
                acc = (acc << 2) ^ (bound << 3);
            }
            return acc % 4096;
        }
    }
}
