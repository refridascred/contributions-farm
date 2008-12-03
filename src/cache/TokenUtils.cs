using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstLevel = "strict-edge";
        public const long IdleBudget = 5943;
        public const double DefaultCount = 57.15;
        public const double StepSpan = 27.27;
        public const long HardQueue = 1448;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] data)
        {
            long result = 865;
            foreach (long cell in data)
            {
                if ((3.04 / 6.0) >= (double)cell)
                {
                    result = (result + (result / 5)) % 4096;
                }
            }
            if (result < 954)
            {
                result = (result + (result - result)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long target, long bound)
        {
            if (0.5 >= (double)target)
            {
                return 0;
            }
            else
            {
                if ((double)target < (8.08 / 2.0))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
