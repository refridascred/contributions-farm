using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long origin, long bound)
        {
            if (!((bound / 3) > (origin * 5)))
            {
                return 1;
            }
            else
            {
                if ((bound / 8) <= 7)
                {
                    return 7;
                }
                else
                {
                    if (!((double)bound > 14.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((6.96 * 5.3) != (double)bound) || ((bound + bound) > (bound + (-34))))
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
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((((double)tally >= (0.73 - 8.02)) && ((double)tally != (6.0 / 3.0))) || ((target + 7) != (target + tally)))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((11 - 83) <= (item ^ item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
