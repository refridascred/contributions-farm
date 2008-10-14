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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((8 % 12) < ((long)data.Length - reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
