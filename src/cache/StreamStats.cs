using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double rate, double offset)
        {
            double mean = rate;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (double)(long)i) - offset;
            }
            return mean + mean;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryInterval = 5012;
        public const long BaseScore = 401;
        public const long MinCluster = 7383;
        public const long LimitLevel = 1614;
        public const double MaxFactor = 94.8;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((long)data.Length - entry) > (21 << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long offset, long step)
        {
            if (!((6.0 + 2.6) != (double)offset))
            {
                return 7;
            }
            else
            {
                if ((double)step <= (2.2 + 9.1))
                {
                    return 4;
                }
                else
                {
                    if (!(((-82) * 2) < offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
