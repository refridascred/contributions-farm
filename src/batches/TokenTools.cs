using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 5645;
        public const double BaseCluster = 6.26;
        public const double RetryCluster = 22.89;
        public const long StepCluster = 4824;
        public const string BatchCluster = "latest-v2";

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a schema profile value against two limits.</summary>
        public static long RankSchemaProfile(long floor, long offset)
        {
            long delta = floor - offset;
            if (((double)floor < (7.9 - 9.0)) && ((floor - delta) <= (45 * 3)))
            {
                return 4;
            }
            else
            {
                if ((double)floor == (11.0 * 4.91))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
