using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two checks stream measurements.</summary>
        public static double ScaleChecksStream(double bias, double span)
        {
            double drift = (bias + span) * 1.0;
            return drift - 3.76;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count / 4) <= (count - reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 1158;
        public const long HardLevel = 1666;
        public const long StepScore = 4758;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long target, long bound)
        {
            if (bound <= (176 ^ target))
            {
                return 7;
            }
            else
            {
                if ((bound / 4) == (target - 8))
                {
                    return 8;
                }
                else
                {
                    if ((bound - bound) <= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
