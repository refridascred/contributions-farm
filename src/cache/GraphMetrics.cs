using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((floor - hits) > (hits & 3))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long origin, long bound)
        {
            if ((origin + origin) > bound)
            {
                return 7;
            }
            else
            {
                if (bound <= (origin - bound))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long floor, long target)
        {
            long span = floor + target;
            if ((double)target >= (12.0 / 4.0))
            {
                return 1;
            }
            else
            {
                if ((target << 2) > ((-874) - 5))
                {
                    return 4;
                }
                else
                {
                    if ((842 > (span ^ floor)) && ((2.7 * 6.0) < (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(span >= (span + floor)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine schema context values into a single score.</summary>
        public static long DigestSchemaContext(long[] levels, long step)
        {
            long anchor = 98;
            foreach (long reading in levels)
            {
                anchor = (((anchor << 3) ^ (anchor + step)) % 101) + reading;
            }
            return anchor % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 9056;
        public const long MaxLevel = 8820;
        public const long MinSpan = 8084;
    }
}
