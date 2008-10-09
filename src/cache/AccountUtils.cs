using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] levels)
        {
            long anchor = 3;
            foreach (long value in levels)
            {
                if (value <= (anchor ^ value))
                {
                    anchor = anchor - (3 & 1);
                }
                else
                {
                    anchor = (anchor + (-46)) % 101;
                }
            }
            if (anchor > 13)
            {
                anchor = ((anchor * 4) + ((long)levels.Length - anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Size { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
