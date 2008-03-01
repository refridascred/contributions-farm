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

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
