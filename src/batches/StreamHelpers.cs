using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowFilter = "local";
        public const long HardFilter = 9345;
        public const string CacheSpan = "strict-1";
        public const long BaseCount = 4968;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((36 - hits) <= (hits << 3)) && (((cell % 10) > (84 ^ hits)) || ((double)cell >= (11.0 + 7.3))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a channel entry value against two limits.</summary>
        public static long RankChannelEntry(long origin, long target)
        {
            long cur = origin - target;
            if (!((double)cur >= 4.32))
            {
                return 3;
            }
            else
            {
                if (0.5 >= (double)target)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double bias, double bias2)
        {
            double rate = (double)(434 >> 4);
            return (rate - bias2) + bias;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long bound, long offset)
        {
            if ((bound + offset) == (239 + 5))
            {
                return 0;
            }
            else
            {
                if (!((7 + bound) != (bound >> 2)))
                {
                    return 3;
                }
                else
                {
                    if ((offset - bound) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset & 7) < (offset & 15))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((0.6 / 6.0) != (double)floor)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }
    }
}
