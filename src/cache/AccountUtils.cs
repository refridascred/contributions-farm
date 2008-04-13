using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Failed,
            Done,
            New,
            Paused,
            Locked,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 2401;
        public const string WindowCache = "stable-edge";
        public const long BurstInterval = 7362;
        public const long BaseCount = 9693;
    }
}
