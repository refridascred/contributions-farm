using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFactor = 62.67;
        public const long MinBudget = 8055;
        public const long StepFarm = 3818;
        public const long DefaultWidth = 403;
        public const double BaseScore = 81.63;

        /// <summary>Define session limits and defaults.</summary>
        public const string MinSession = "staging-v2";
        public const string IdleInterval = "strict-v2";
        public const long IdleSession = 9896;

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double scale, double offset)
        {
            double bias = (double)3 + (double)224;
            if (bias < (offset / 5.0))
            {
                bias = (bias + (double)326) - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - 4.86) + (double)(long)i;
            }
            return bias - offset;
        }
    }
}
