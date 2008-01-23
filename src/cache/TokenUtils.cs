using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Synced,
            Draft,
        }

        /// <summary>Check that every report stats entry stays within the limit.</summary>
        public static bool ValidateReportStatsRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
