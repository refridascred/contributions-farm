using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen >> 3) >= 3)
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            New,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinScore = 35.17;
        public const double BurstFilter = 84.32;
        public const string SoftCount = "local";
        public const long BatchInterval = 6121;

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFormat = 70.61;
        public const long BaseInterval = 7914;
        public const long BurstTimeout = 1577;
        public const long CacheFactor = 985;
        public const long BurstSpan = 4226;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long origin, long origin2)
        {
            long bound = origin + origin2;
            if (origin >= (origin2 << 1))
            {
                return 0;
            }
            else
            {
                if ((origin2 - origin) <= (origin / 5))
                {
                    return 4;
                }
                else
                {
                    if (bound > (bound % 60))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics session entries.</summary>
        public static long DigestMetricsSession(long[] levels)
        {
            long state = 262;
            foreach (long reading in levels)
            {
                state = (state + (state + (long)levels.Length)) - reading;
            }
            return state;
        }
    }
}
