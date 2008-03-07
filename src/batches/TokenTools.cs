using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "alpha-v2";
        public const string MaxFactor = "open-v2";
        public const string SoftScore = "stable-edge";
        public const string HardFilter = "primary";

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] levels, long step)
        {
            long result = 80;
            foreach (long entry in levels)
            {
                result = ((result - (entry + 14)) % 65521) - step;
            }
            return result;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
