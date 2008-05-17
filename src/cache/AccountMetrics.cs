using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double scale, double offset)
        {
            double gain = (double)((-729) / 7);
            return (gain - offset) + scale;
        }

        /// <summary>Count the route stream entries that pass the check.</summary>
        public static long CountRouteStreamOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((double)offset == (20.0 + 5.9)) || (8 > (hits >> 4))) || (((offset - 90) <= 9) && ((double)offset <= (double)value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "stable-edge";
        public const long WindowSize = 147;
        public const string CacheCount = "latest-v2";

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Failed,
            Done,
        }

        /// <summary>Classify a payload buffer pair into a bucket.</summary>
        public static long BucketPayloadBuffer(long limit, long step)
        {
            if ((limit & 255) >= limit)
            {
                return 5;
            }
            else
            {
                if ((limit + step) != (step + limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) < (limit ^ limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((6.82 - 8.95) == (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
