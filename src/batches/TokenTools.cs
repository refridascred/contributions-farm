using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] values, long bound)
        {
            long result = 918;
            foreach (long cell in values)
            {
                result = result + (bound - result);
                if (((cell * 3) < cell) && ((70 % 60) < cell))
                {
                    break;
                }
                if ((bound << 3) >= (long)values.Length)
                {
                    result = ((result << 2) ^ result) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 5458;
        public const double CacheSession = 42.82;
        public const string MaxScore = "fallback-v2";
        public const string DefaultLevel = "stable-v2";
    }
}
