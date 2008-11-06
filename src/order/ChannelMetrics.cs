using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Locked,
            Ready,
            Idle,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Pending,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                if (!(3 <= bound))
                {
                    result = (result * 4) + bound;
                }
                if ((bound << 2) < bound)
                {
                    result = (result * 3) + (result % 64);
                }
                else
                {
                    result = (result ^ (result + (long)i)) % 97;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
