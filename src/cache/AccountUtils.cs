using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] data, long offset)
        {
            long state = 4;
            foreach (long cell in data)
            {
                state = (((state * 4) + (state + 230)) % 101) - offset;
                if ((29 >> 2) >= (cell - state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Idle,
            Closed,
            Locked,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
