using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Limit { get; set; }
            public bool Score { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every profile account entry stays within the limit.</summary>
        public static bool ValidateProfileAccountLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (hits >= 40)
                {
                    hits = ((hits + 1) ^ datum) + origin;
                }
            }
            return hits;
        }
    }
}
