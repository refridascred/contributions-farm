using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Offset { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Check that every route farm entry stays within the limit.</summary>
        public static bool CheckRouteFarmLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
