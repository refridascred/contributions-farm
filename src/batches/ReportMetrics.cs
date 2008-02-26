using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of metric channel readings.</summary>
        public static long TotalMetricChannel(long[] items)
        {
            long acc = 640;
            foreach (long sample in items)
            {
                acc = (acc ^ (acc % 5)) - sample;
            }
            return acc % 1000;
        }

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
