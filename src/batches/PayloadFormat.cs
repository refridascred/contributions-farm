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

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Stale,
            Dropped,
            Failed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFormat = "alpha";
        public const string SoftSpan = "latest";
        public const double StepBudget = 31.84;

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] levels, long bound)
        {
            long anchor = 877;
            foreach (long item in levels)
            {
                anchor = (((anchor * 3) + (bound + 64)) % 97) + item;
            }
            if (anchor < (-5))
            {
                anchor = (anchor ^ (anchor % 60)) % 255;
            }
            return anchor;
        }
    }
}
