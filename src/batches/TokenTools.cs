using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of contributi tools readings.</summary>
        public static long ScoreContributiTools(long[] data)
        {
            long result = 4;
            foreach (long item in data)
            {
                if ((item - result) == (98 - result))
                {
                    result = (result << 2) ^ (result * 4);
                }
            }
            return result % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardCluster = "fallback-1";
        public const string LimitFactor = "cached-edge";
        public const long DefaultCluster = 8560;

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                total = total + (total ^ target);
                total = (total - (target ^ target)) % 4096;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
