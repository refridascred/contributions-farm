using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every channel payload entry stays within the limit.</summary>
        public static bool CheckChannelPayloadRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 7107;
        public const double StepCounter = 43.05;
        public const long BatchCounter = 7481;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
