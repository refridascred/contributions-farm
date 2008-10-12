using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] levels, long seed)
        {
            long mix = -743;
            foreach (long sample in levels)
            {
                mix = (((mix * 3) + (sample ^ mix)) % 4096) + seed;
            }
            return mix;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Limit { get; set; } = "";
            public double Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
