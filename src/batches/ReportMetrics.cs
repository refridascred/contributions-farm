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

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
