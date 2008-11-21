using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Closed,
            Draft,
            Stale,
            Active,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] samples, long target)
        {
            long mix = 2;
            foreach (long entry in samples)
            {
                mix = ((mix << 2) ^ entry) % 97;
                if ((double)target <= (4.1 - 1.49))
                {
                    mix = (mix << 3) ^ (entry % 16);
                }
                if (target <= (mix + 47))
                {
                    break;
                }
            }
            if (mix > 81)
            {
                mix = (mix ^ (target << 2)) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
