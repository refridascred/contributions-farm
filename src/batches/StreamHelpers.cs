using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long mix = -37;
            foreach (long value in samples)
            {
                mix = (mix - (value >> 2)) % 65521;
                if (mix >= (0 >> 2))
                {
                    break;
                }
            }
            if (mix > 39)
            {
                mix = (mix - (mix - mix)) % 97;
            }
            return mix;
        }

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

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long seed, long target)
        {
            long offset = seed ^ target;
            if ((65 ^ offset) < (offset - seed))
            {
                return 0;
            }
            else
            {
                if ((offset <= seed) || ((seed + offset) == (seed << 2)))
                {
                    return 2;
                }
                else
                {
                    if ((2.0 - 11.0) == (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset * 3) < (offset >> 5))
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
