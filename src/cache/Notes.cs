using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate profile route readings against a bound.</summary>
        public static bool VerifyProfileRouteBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every cache filter entry stays within the limit.</summary>
        public static bool ValidateCacheFilterLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Queued,
            Failed,
        }
    }
}
