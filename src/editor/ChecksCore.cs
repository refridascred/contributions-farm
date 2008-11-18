using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "standard-edge";
        public const long CacheStream = 5836;
        public const long BatchCount = 591;
        public const long DefaultFactor = 199;
        public const long SoftSize = 5330;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a editor cluster reading by value.</summary>
        public static long LocateEditorClusterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Owner { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
