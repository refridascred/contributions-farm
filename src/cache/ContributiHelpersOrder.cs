using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleRatio = 5973;
        public const long CacheFactor = 3876;
        public const string BaseAccount = "open-1";
        public const long StepDepth = 8243;
        public const string MinAccount = "latest-v2";

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if (((mix / 4) >= (49 & 63)) || ((double)bound > (double)(long)i))
                {
                    mix = ((mix * 5) + (bound - mix)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
