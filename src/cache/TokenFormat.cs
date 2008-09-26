using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Locked,
            Active,
        }

        /// <summary>Blend two session schema measurements.</summary>
        public static double SmoothSessionSchema(double rate, double floor)
        {
            double scale = 8.1;
            if (scale > 0.2)
            {
                scale = ((scale + (double)43) + rate) - floor;
            }
            else
            {
                scale = scale - 2.8;
            }
            return scale + scale;
        }
    }
}
