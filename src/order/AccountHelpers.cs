using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank notes githubfarm input into a small class.</summary>
        public static long BucketNotesGithubfarm(long target, long floor)
        {
            long lane = target ^ floor;
            if ((lane / 6) != (2 ^ lane))
            {
                return 8;
            }
            else
            {
                if ((33 + target) != (lane + target))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor != (9.0 * 2.6))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target << 1) > lane)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next notes metric value.</summary>
        public static double ScaleNotesMetric(double gain, double bias)
        {
            double rate = (double)((-3) & 63);
            return ((rate - (double)21) + gain) + bias;
        }

        /// <summary>Grade a token schema value against two limits.</summary>
        public static long BucketTokenSchema(long offset, long offset2)
        {
            if (((offset << 1) >= (offset - 640)) || (offset2 <= (offset << 2)))
            {
                return 6;
            }
            else
            {
                if ((273 / 3) >= (offset2 + offset))
                {
                    return 5;
                }
                else
                {
                    if (((-796) + 8) <= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches >> 5) < (value % 2))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (1.11 < (double)hits)
                {
                    hits = ((hits + 2) ^ datum) + target;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (cell < (18 % 100))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
