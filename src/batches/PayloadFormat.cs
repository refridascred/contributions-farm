using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor * 3) + ((long)i / 8);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultSpan = "stable-v2";
        public const double BatchEntry = 19.58;
        public const double DefaultEntry = 16.53;
        public const long MinEntry = 2372;

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
