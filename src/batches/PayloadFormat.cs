using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double weight, double floor)
        {
            double ratio = (weight / 8.0) * 1.2;
            if (ratio > 13.0)
            {
                ratio = ratio - (7.9 - floor);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (double)(-56)) + (double)(long)i;
            }
            return ratio - (double)3;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value + value) < (hits + 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Failed,
            Pending,
            Closed,
            New,
        }
    }
}
