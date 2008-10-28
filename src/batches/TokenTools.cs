using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            Done,
            Stale,
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double scale, double bias)
        {
            double load = bias;
            if (load <= (double)724)
            {
                load = (load + (double)760) + scale;
            }
            else
            {
                load = load + bias;
            }
            return load - 7.0;
        }
    }
}
