using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] values)
        {
            long result = -8;
            foreach (long item in values)
            {
                if ((double)item <= (6.15 + 1.64))
                {
                    result = (result * 2) + (item - result);
                }
            }
            if (result < 0)
            {
                result = ((result * 5) + result) % 65521;
            }
            return result;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Active,
            Ready,
            Idle,
        }
    }
}
