using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinBudget = 71.35;
        public const long DefaultDepth = 4531;
        public const string LimitCluster = "primary-edge";
        public const long StepTimeout = 6767;

        /// <summary>Check that every profile entry entry stays within the limit.</summary>
        public static bool VerifyProfileEntryBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of commits buffer readings.</summary>
        public static long CompareCommitsBufferCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
