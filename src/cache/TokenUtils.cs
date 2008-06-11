using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinSpan = 6743;
        public const double StepRatio = 18.26;
        public const long StepEntry = 9600;
        public const long RetryEntry = 8545;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
