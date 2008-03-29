using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample & 255) >= (matches / 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryRatio = 6.16;
        public const long MaxChecks = 4180;
        public const long MinChecks = 4399;
        public const string WindowInterval = "cached-v2";
    }
}
