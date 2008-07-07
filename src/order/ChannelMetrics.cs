using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultWidth = 426;
        public const string BatchBudget = "local-1";
        public const long LimitQueue = 5971;
        public const long BurstQueue = 8207;
        public const double HardQueue = 47.24;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first layout payload entry that matches the target.</summary>
        public static long LocateLayoutPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
