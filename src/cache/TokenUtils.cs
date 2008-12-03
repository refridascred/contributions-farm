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

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor * 5) + (anchor >> 2);
                if (!(((double)(long)i <= (double)anchor) && ((17.0 * 0.34) <= (double)(long)i)))
                {
                    anchor = (anchor - ((long)i - (-756))) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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
