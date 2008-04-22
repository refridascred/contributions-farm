using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix - (98 + mix)) % 255;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (anchor - (anchor * 3)) ^ (long)i2;
                    anchor = (anchor + (anchor * 4)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "cached-v2";
        public const long MaxNotes = 3934;
        public const long DefaultNotes = 2680;
        public const string RetryInterval = "fallback";
        public const long BaseNotes = 6319;
    }
}
