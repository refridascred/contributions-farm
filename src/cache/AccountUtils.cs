using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double bias2)
        {
            double weight = bias;
            if (weight <= bias2)
            {
                weight = weight - bias2;
            }
            else
            {
                weight = weight + (double)(-98);
            }
            return weight + bias;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Done,
            Dropped,
            Paused,
        }
    }
}
