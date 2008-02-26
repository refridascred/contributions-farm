using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 7253;
        public const long BatchDepth = 7784;
        public const double BaseWindow = 58.14;

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a already payload pair into a bucket.</summary>
        public static long BucketAlreadyPayload(long step, long bound)
        {
            long edge = step ^ bound;
            if (((double)step != (double)bound) || ((double)step <= (3.26 - 17.0)))
            {
                return 5;
            }
            else
            {
                if ((bound % 60) <= edge)
                {
                    return 7;
                }
                else
                {
                    if ((step - step) <= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
