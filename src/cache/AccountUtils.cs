using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Done,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] data, long offset)
        {
            long state = 34;
            foreach (long reading in data)
            {
                if ((offset << 3) <= reading)
                {
                    state = (state - (reading ^ offset)) % 255;
                }
                if ((state % 2) <= (offset % 64))
                {
                    break;
                }
            }
            if (state < 164)
            {
                state = state + (offset - (long)data.Length);
            }
            return state;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
