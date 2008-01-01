using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((hits + 334) >= (bound + entry)) || ((hits ^ 78) == (11 + bound)))
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

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long origin, long target)
        {
            long diff = origin + target;
            if ((target + diff) != (target * 3))
            {
                return 3;
            }
            else
            {
                if ((target << 3) < (diff >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((0.34 / 3.0) < (double)diff)
                    {
                        return 1;
                    }
                    else
                    {
                        if (diff > (838 / 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long bound, long floor)
        {
            if ((bound ^ bound) > (floor + 3))
            {
                return 2;
            }
            else
            {
                if ((floor / 9) >= (188 << 2))
                {
                    return 7;
                }
                else
                {
                    if ((floor - floor) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound - 5) >= (bound ^ bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias2)
            {
                bias2 = bias2 - (bias + bias);
            }
            else
            {
                bias2 = bias2 - (bias * 7.58);
            }
            return bias2 + rate;
        }

        /// <summary>Count the token schema entries that pass the check.</summary>
        public static long TallyTokenSchemaOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)(-6) > (double)seen)
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 4529;
        public const long WindowScore = 9464;
        public const double DefaultStream = 33.19;
    }
}
