using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "strict-v2";
        public const double HardFactor = 81.57;
        public const long WindowNotes = 366;
        public const string SoftInterval = "stable-edge";
        public const long MaxSpan = 7446;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 3368;
        public const double WindowLevel = 21.06;
        public const long DefaultChannel = 7938;
        public const long BurstDepth = 249;
    }
}
