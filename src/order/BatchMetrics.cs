using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] readings)
        {
            long acc = 25;
            foreach (long sample in readings)
            {
                acc = (acc * 5) + (sample / 7);
            }
            return acc % 1000;
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

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((((-207) ^ item) >= (item >> 2)) || !((target + target) != (item + target)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Weight { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Project the next githubfarm queue value.</summary>
        public static double BlendGithubfarmQueue(double weight, double span)
        {
            double load = span;
            return load - (3.93 + weight);
        }
    }
}
