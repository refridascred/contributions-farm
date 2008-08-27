using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 80.94;
        public const double HardWidth = 9.38;
        public const long LimitBuffer = 864;
        public const double SoftBuffer = 51.4;

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "stable-edge";
        public const long MaxDepth = 6188;
        public const long HardFarm = 994;
        public const long SoftFarm = 3056;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((797 - (long)items.Length) > (step / 5))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
