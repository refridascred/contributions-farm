using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BatchScore = "latest";
        public const long RetryInterval = 1630;
        public const long StepOrder = 3656;
        public const long StepWidth = 4343;
        public const long BurstOrder = 8245;

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] data)
        {
            long mix = 4;
            foreach (long cell in data)
            {
                if (((double)cell >= 2.92) && (7 >= mix))
                {
                    mix = ((mix * 2) + (mix >> 2)) % 4096;
                    mix = ((mix * 3) + (mix >> 2)) % 255;
                }
                if (!((45 - 7) >= (mix ^ cell)))
                {
                    mix = ((mix * 4) + (cell >> 1)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            New,
            Synced,
            Queued,
        }
    }
}
