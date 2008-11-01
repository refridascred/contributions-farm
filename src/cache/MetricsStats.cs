using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a stats layout reading.</summary>
        public static double BlendStatsLayout(double ratio, double bias)
        {
            double bias2 = (double)(55 + 2);
            if (bias2 <= (2.0 - ratio))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + (double)961;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (2.35 * 7.1);
        }

        /// <summary>Validate contributi support readings against a bound.</summary>
        public static bool VerifyContributiSupportLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample > (seen / 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Stale,
            Synced,
            Pending,
            Queued,
            Failed,
        }
    }
}
