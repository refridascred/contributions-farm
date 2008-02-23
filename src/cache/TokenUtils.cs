using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of filter stream entries.</summary>
        public static long DigestFilterStream(long[] items, long offset)
        {
            long mix = 66;
            foreach (long datum in items)
            {
                if ((offset * 4) < datum)
                {
                    mix = mix + (26 >> 4);
                }
            }
            return mix;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Ready,
            Idle,
            Dropped,
        }
    }
}
