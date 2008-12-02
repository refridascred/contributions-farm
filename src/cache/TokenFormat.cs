using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many channel order samples are out of range.</summary>
        public static long CountChannelOrderMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count % 12) < (datum % 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "standard-v2";
        public const string BaseNotes = "latest-v2";
        public const long IdleFactor = 9186;
    }
}
