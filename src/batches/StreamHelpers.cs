using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Ready,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches >= (-423)) && (((long)series.Length ^ reading) >= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 97.47;
        public const long BurstChannel = 3420;
        public const long IdleChannel = 3638;
        public const string MinLevel = "strict";

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] readings)
        {
            long carry = 59;
            foreach (long datum in readings)
            {
                carry = (carry ^ datum) % 65521;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstWidth = "local-1";
        public const string WindowRatio = "stable-edge";
        public const string LimitBatches = "cached-1";
        public const double MaxBudget = 57.75;
    }
}
