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

        /// <summary>Validate schema account readings against a bound.</summary>
        public static bool GuardSchemaAccountLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
