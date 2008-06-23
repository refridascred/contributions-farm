using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long limit, long floor)
        {
            if ((58 <= limit) && ((limit + limit) <= floor))
            {
                return 6;
            }
            else
            {
                if (floor <= ((-230) % 24))
                {
                    return 1;
                }
                else
                {
                    if ((887 + floor) != (floor - 80))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            Failed,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] items, long limit)
        {
            long mark = 786;
            foreach (long reading in items)
            {
                mark = ((mark << 3) ^ (limit << 1)) ^ reading;
            }
            return mark;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double ratio, double floor)
        {
            double gain = floor / 5.0;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + (floor * 7.73)) + (double)(long)i) + ratio;
            }
            return gain - (double)626;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((7.4 + 0.74) > (double)bound)
                {
                    seen = (seen + 3) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
