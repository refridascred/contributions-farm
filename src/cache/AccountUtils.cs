using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
            public double Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Idle,
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((2 >> 2) == (datum / 3)) && ((datum ^ 306) >= hits)) || !((hits >> 1) >= (68 - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
