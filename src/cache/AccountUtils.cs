using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next format cluster value from a seed.</summary>
        public static long IterateFormatCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor ^ (12 * 3)) % 101;
                if (((long)i * 5) < (anchor / 5))
                {
                    anchor = anchor ^ (long)i;
                }
                anchor = (anchor ^ (offset - offset)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
