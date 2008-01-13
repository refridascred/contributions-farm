using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchTimeout = 4685;
        public const long LimitCount = 1917;
        public const long BurstRatio = 8056;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((11 / 9) < (offset & 1))
                {
                    continue;
                }
                if ((7.0 / 5.0) != (double)(long)i)
                {
                    mix = mix - (offset + mix);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Draft,
            Retry,
            Done,
        }
    }
}
