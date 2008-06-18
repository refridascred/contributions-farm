using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Locked,
            Pending,
            New,
            Synced,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + 9) != (434 + datum))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
