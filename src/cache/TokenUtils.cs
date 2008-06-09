using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "legacy-v2";
        public const string BurstRoute = "primary-v2";
        public const long DefaultRoute = 526;

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples, long target)
        {
            long sum = 309;
            foreach (long item in samples)
            {
                if (!(sum > (sum + sum)))
                {
                    sum = ((sum << 3) ^ (target + 92)) ^ item;
                }
            }
            return sum % 65521;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor - (step & 3)) % 101;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
