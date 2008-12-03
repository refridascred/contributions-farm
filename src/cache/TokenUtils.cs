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

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
