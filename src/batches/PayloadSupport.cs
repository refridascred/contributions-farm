using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double weight, double bias)
        {
            double weight2 = (double)(139 - 11);
            if (weight2 < (double)9)
            {
                weight2 = weight2 + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - (9.0 - bias)) + (double)(long)i;
            }
            return weight2 + (double)6;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
