using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] data, long offset)
        {
            long mix = 64;
            foreach (long reading in data)
            {
                if ((reading >= (offset + mix)) && (reading <= 337))
                {
                    continue;
                }
                else
                {
                    mix = (mix + reading) % 101;
                    mix = (mix << 2) ^ (offset + (long)data.Length);
                }
                mix = mix ^ (381 + offset);
            }
            if (mix < 216)
            {
                mix = ((mix * 5) + (mix / 4)) % 4096;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseCount = 7533;
        public const long MaxSpan = 8872;
        public const string IdleTimeout = "legacy-v2";

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitScore = 7429;
        public const long DefaultStats = 350;
        public const long StepLevel = 9463;
    }
}
