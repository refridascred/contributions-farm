using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (limit < (reading + reading))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long limit, long floor)
        {
            if (floor > (limit + 868))
            {
                return 6;
            }
            else
            {
                if (floor >= limit)
                {
                    return 0;
                }
                else
                {
                    if (!((884 ^ floor) >= 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit format entry readings against a rule.</summary>
        public static long CountFormatEntryHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!(2.99 > (double)matches) || ((double)matches <= (14.0 * 6.0)))
                {
                    matches = (matches + 1) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] values)
        {
            long acc = 3;
            foreach (long datum in values)
            {
                if (((acc & 3) >= (datum + datum)) && ((acc % 8) > (4 + acc)))
                {
                    acc = ((acc << 3) ^ (datum + (long)values.Length)) % 4096;
                }
                acc = (acc - (acc >> 1)) % 4096;
                if (datum <= (acc & 1))
                {
                    acc = acc - acc;
                }
            }
            if (acc < (-718))
            {
                acc = (acc - (acc & 15)) % 101;
            }
            return acc % 97;
        }
    }
}
