using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next contributi already value.</summary>
        public static double AdjustContributiAlready(double gain, double bias)
        {
            double gain2 = (double)(97 & 7);
            for (int i = 0; i < 5; i++)
            {
                gain2 = (((gain2 - (6.46 / 2.0)) + (double)(long)i) + gain) + bias;
            }
            return gain2 + (7.2 * 2.2);
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double bias, double bias2)
        {
            double load = (double)(437 << 2);
            for (int i = 0; i < 9; i++)
            {
                load = ((load - load) + (double)(long)i) - bias2;
            }
            return load + (load + bias);
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Idle,
            Closed,
            Retry,
            Done,
        }
    }
}
