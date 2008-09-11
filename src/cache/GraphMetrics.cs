using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit queue metrics readings against a rule.</summary>
        public static long AuditQueueMetricsMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum > (hits / 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank token payload input into a small class.</summary>
        public static long BucketTokenPayload(long seed, long limit)
        {
            if (!((143 + seed) <= seed))
            {
                return 2;
            }
            else
            {
                if (!((seed + limit) > limit))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed > (6.9 * 9.06))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit >> 5) != (seed / 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 1088;
        public const string RetrySize = "strict-v2";
        public const string BaseStream = "alpha-1";
        public const long RetryTimeout = 7209;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading < count)
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double rate, double offset)
        {
            double load = rate;
            if (load < (load + load))
            {
                load = (load - load) - offset;
            }
            return load + (load + rate);
        }
    }
}
