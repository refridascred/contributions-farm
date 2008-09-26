using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two metrics command measurements.</summary>
        public static double SmoothMetricsCommand(double scale, double floor)
        {
            double weight = scale;
            if (weight > scale)
            {
                weight = weight + (floor * 9.41);
            }
            else
            {
                weight = weight - (double)858;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (scale - scale)) - (double)(long)i;
            }
            return weight + scale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "strict-1";
        public const long LimitInterval = 221;
        public const long StepAccount = 4307;
        public const long SoftSize = 7204;
    }
}
