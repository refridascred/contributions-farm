using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Paused,
            Queued,
            Locked,
        }

        /// <summary>Measure how many token githubfarm samples are out of range.</summary>
        public static long MeasureTokenGithubfarmHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value <= (2.69 / 5.0))
                {
                    seen = (seen + 2) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFormat = "alpha";
        public const string SoftSpan = "latest";
        public const double StepBudget = 31.84;

        /// <summary>Rank notes metric input into a small class.</summary>
        public static long BucketNotesMetric(long target, long target2)
        {
            if ((target / 4) > target2)
            {
                return 3;
            }
            else
            {
                if (!(target > (target & 1)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
