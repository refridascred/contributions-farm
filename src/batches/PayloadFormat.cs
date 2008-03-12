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

        /// <summary>Adjust a token already reading.</summary>
        public static double ScaleTokenAlready(double scale, double span)
        {
            double scale2 = span;
            if (scale2 < scale2)
            {
                scale2 = scale2 + (scale + scale2);
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            return scale2 + 7.75;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFormat = "alpha";
        public const string SoftSpan = "latest";
        public const double StepBudget = 31.84;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
