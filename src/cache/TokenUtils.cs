using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string IdleRoute = "alpha-1";
        public const long BurstRoute = 4021;
        public const long WindowRoute = 560;
        public const long MinLevel = 3008;
        public const double DefaultInterval = 0.83;

        /// <summary>Compare every pair of schema command readings.</summary>
        public static long OverlapSchemaCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultDepth = 8014;
        public const long BaseReport = 9903;
        public const long DefaultSize = 3998;
    }
}
