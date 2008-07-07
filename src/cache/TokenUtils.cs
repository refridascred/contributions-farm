using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                if (!!((step - 6) < total))
                {
                    total = ((total * 2) + (long)i) % 1000;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double offset)
        {
            double scale = ratio;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - 4.0) + (double)(long)i) - offset;
            }
            return scale + (double)1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "stable";
        public const double SoftInterval = 30.77;
        public const long WindowBudget = 2309;
        public const long IdleInterval = 4529;
        public const string HardProfile = "open-v2";
    }
}
