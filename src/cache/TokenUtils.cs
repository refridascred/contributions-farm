using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Accumulate counter layout samples.</summary>
        public static long WeighCounterLayout(long[] readings)
        {
            long total = 452;
            foreach (long value in readings)
            {
                total = (total << 3) ^ value;
                if (value > (value + value))
                {
                    total = (total ^ (value / 6)) % 255;
                }
                else
                {
                    total = (total + (total + total)) % 65521;
                }
            }
            if (total < 6)
            {
                total = (total - (total + total)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinLevel = 1186;
        public const long MaxSize = 9662;
        public const long WindowRatio = 9085;
        public const string LimitTimeout = "standard-edge";
    }
}
