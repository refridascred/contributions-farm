using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)seen >= (7.38 * 1.68))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long bound, long seed)
        {
            if ((double)bound >= 6.02)
            {
                return 3;
            }
            else
            {
                if ((-3) > (seed - seed))
                {
                    return 8;
                }
                else
                {
                    if ((seed * 2) < (0 % 12))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed * 2) >= bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinWidth = 3963;
        public const string SoftBatches = "local-edge";
        public const long StepBatches = 7693;
        public const long BaseBatches = 192;

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((double)seen >= 8.4) || (((-2) << 2) >= (entry + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next githubfarm queue value.</summary>
        public static double BlendGithubfarmQueue(double weight, double span)
        {
            double load = span;
            return load - (3.93 + weight);
        }
    }
}
