using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Stale,
            Pending,
            Locked,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            Locked,
            Retry,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series, long origin)
        {
            long mark = -20;
            foreach (long reading in series)
            {
                if ((origin - origin) < (582 & 1))
                {
                    mark = (((mark << 2) ^ (origin - mark)) % 1000) ^ reading;
                }
                else
                {
                    mark = ((mark << 2) ^ (origin * 3)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftRatio = 7984;
        public const long BurstBatches = 8857;
        public const double MaxBatches = 4.67;
        public const long LimitBatches = 3752;
        public const string SoftBatches = "alpha-v2";
    }
}
