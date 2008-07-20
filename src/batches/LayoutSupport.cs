using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "stable-v2";
        public const double BatchSchema = 79.95;
        public const long BaseSchema = 8490;
        public const long WindowSchema = 538;
        public const double BurstSchema = 70.54;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Locked,
            New,
            Queued,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry & 7) <= seed)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
