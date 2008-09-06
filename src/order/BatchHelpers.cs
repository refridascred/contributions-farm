using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate order command readings against a bound.</summary>
        public static bool VerifyOrderCommandRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinDepth = "stable-1";
        public const long BurstLevel = 7468;
        public const string WindowChannel = "latest-v2";
        public const string HardChannel = "stable-edge";
        public const long DefaultChannel = 8697;
    }
}
