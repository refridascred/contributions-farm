using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit support editor readings against a rule.</summary>
        public static long AuditSupportEditorOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally + reading) >= (-95))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches > (double)63)
                {
                    matches = ((matches + 1) + entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Classify a contributi profile pair into a bucket.</summary>
        public static long BucketContributiProfile(long seed, long bound)
        {
            if (!((seed - 562) < ((-297) >> 3)))
            {
                return 8;
            }
            else
            {
                if ((seed >= ((-8) - seed)) || ((double)bound >= 6.0))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
