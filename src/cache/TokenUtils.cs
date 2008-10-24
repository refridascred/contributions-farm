using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] data, long target)
        {
            long anchor = 6;
            foreach (long value in data)
            {
                if (value >= (value + target))
                {
                    anchor = anchor ^ ((-791) << 2);
                }
                else
                {
                    anchor = ((anchor * 4) + (5 + value)) % 65521;
                }
                if (!((target - (-4)) != (6 >> 3)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen <= sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
