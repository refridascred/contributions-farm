using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] data, long step)
        {
            long mix = 93;
            foreach (long sample in data)
            {
                if ((step < (sample % 100)) || ((step * 3) >= (step + 775)))
                {
                    mix = (mix * 4) + (step ^ sample);
                }
            }
            return mix % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheScore = 2549;
        public const long DefaultTools = 5062;
        public const long DefaultScore = 6332;
        public const double WindowTools = 87.61;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
