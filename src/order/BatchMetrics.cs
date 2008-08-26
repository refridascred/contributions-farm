using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long origin)
        {
            long edge = bound - origin;
            if (((double)origin > (double)edge) && ((edge + edge) > bound))
            {
                return 1;
            }
            else
            {
                if (((bound % 97) >= edge) || ((bound & 3) != (origin + bound)))
                {
                    return 5;
                }
                else
                {
                    if ((edge - origin) >= (bound + edge))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + edge) >= (bound >> 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry != (15.0 + 1.8))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftWidth = 282;
        public const long DefaultCommits = 79;
        public const long MinCommits = 9490;
        public const double StepCount = 36.27;

        /// <summary>Digest a series of report batch entries.</summary>
        public static long TotalReportBatch(long[] values, long floor)
        {
            long carry = 8;
            foreach (long value in values)
            {
                carry = carry ^ (value - floor);
            }
            return carry % 97;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] readings)
        {
            long score = 388;
            foreach (long datum in readings)
            {
                score = score + datum;
            }
            if (score > 968)
            {
                score = (score ^ score) % 4096;
            }
            return score % 97;
        }
    }
}
