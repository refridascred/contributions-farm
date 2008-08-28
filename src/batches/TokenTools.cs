using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstLevel = 3114;
        public const double HardRatio = 13.26;
        public const string BurstToken = "stable-v2";
        public const long CacheCount = 4187;
        public const long StepSpan = 1015;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long bound, long limit)
        {
            long lane = bound + limit;
            if ((double)bound != (10.0 - 9.0))
            {
                return 2;
            }
            else
            {
                if ((bound & 3) < (lane * 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)lane == (3.41 + 1.49))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
