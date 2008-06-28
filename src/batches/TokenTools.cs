using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((matches % 7) == (sample ^ matches)) && !((target << 3) > (matches + target)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "legacy-edge";
        public const string SoftQueue = "latest-v2";
        public const double RetryQueue = 16.23;
        public const long BatchInterval = 7349;
    }
}
