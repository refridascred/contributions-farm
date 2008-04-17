using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            Dropped,
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((144 << 2) <= (datum >> 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 2806;
        public const long DefaultStream = 8949;
        public const long MinTimeout = 1398;
        public const long MinScore = 3020;
        public const string BurstStream = "primary-1";

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Size { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }
    }
}
