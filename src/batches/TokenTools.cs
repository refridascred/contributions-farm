using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Pending,
            Synced,
            Dropped,
            Draft,
            Queued,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] values, long limit)
        {
            long state = 150;
            foreach (long reading in values)
            {
                state = (state + (state >> 1)) ^ reading;
            }
            if (state > (-391))
            {
                state = ((state << 2) ^ (limit % 60)) % 101;
            }
            return state;
        }
    }
}
