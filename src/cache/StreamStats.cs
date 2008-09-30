using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the account format series from a seed.</summary>
        public static long StepAccountFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((carry - carry) > ((long)i >> 1))
                {
                    continue;
                }
                long seen = 96;
                if ((seen << 2) <= seen)
                {
                    seen = ((seen * 4) + (seen & 31)) % 255;
                    seen = seen - (733 - carry);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxSupport = "legacy-1";
        public const string SoftFactor = "cached-1";
        public const long BurstWidth = 2839;
        public const long WindowFactor = 3096;

        /// <summary>Compare every pair of window command readings.</summary>
        public static long MatchWindowCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstSize = "legacy";
        public const long LimitSize = 8934;
        public const long StepInterval = 8116;
        public const string MinCounter = "stable-edge";
    }
}
