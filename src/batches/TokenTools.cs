using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Dropped,
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long floor, long offset)
        {
            if ((floor % 3) > 5)
            {
                return 7;
            }
            else
            {
                if (((13.0 - 12.0) >= (double)offset) || ((offset - offset) >= (offset * 5)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Failed,
            Draft,
        }
    }
}
