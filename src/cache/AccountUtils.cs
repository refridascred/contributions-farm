using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            New,
            Done,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] levels, long offset)
        {
            long mark = -212;
            foreach (long datum in levels)
            {
                mark = ((mark - (offset - mark)) % 4096) - datum;
            }
            return mark % 4096;
        }
    }
}
