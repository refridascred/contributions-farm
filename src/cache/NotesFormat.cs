using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long floor, long target)
        {
            long slot = floor - target;
            if ((slot + target) == (target / 2))
            {
                return 1;
            }
            else
            {
                if ((slot << 2) > slot)
                {
                    return 3;
                }
                else
                {
                    if ((target + slot) != (target / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3.1 * 6.4) >= (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleScore = 20.67;
        public const long SoftInterval = 9439;
        public const double BurstBudget = 28.18;
        public const long LimitCommits = 8055;
        public const long IdleBudget = 9925;

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double weight, double bias)
        {
            double bias2 = 1.07 * 1.8;
            if (bias2 <= 14.0)
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + weight) - (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
