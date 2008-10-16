using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double HardStats = 19.47;
        public const long IdleBudget = 905;
        public const long WindowStats = 3775;
        public const long LimitRatio = 3329;
        public const long MaxFactor = 2131;

        /// <summary>Project the next graph format value.</summary>
        public static double ScaleGraphFormat(double rate, double offset)
        {
            double bias = rate;
            if (bias < offset)
            {
                bias = bias + (offset * 15.0);
            }
            return bias + 3.0;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long offset, long limit)
        {
            if ((double)limit >= 18.0)
            {
                return 5;
            }
            else
            {
                if ((limit ^ offset) < (limit - limit))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
