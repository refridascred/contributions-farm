using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Stale,
            Failed,
        }

        /// <summary>Digest a series of route session entries.</summary>
        public static long ScoreRouteSession(long[] samples)
        {
            long anchor = 9;
            foreach (long reading in samples)
            {
                if ((reading / 2) < reading)
                {
                    anchor = anchor ^ (reading - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
