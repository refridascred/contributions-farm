using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Paused,
            Pending,
            Draft,
            Active,
            Closed,
        }

        /// <summary>Project the next account channel value.</summary>
        public static double ProjectAccountChannel(double bias, double bias2)
        {
            double gain = (double)(934 * 3);
            if (gain > bias)
            {
                gain = gain - (gain + bias2);
            }
            else
            {
                gain = gain - (bias - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (gain * 7.0)) - (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Idle,
            Done,
            Retry,
        }
    }
}
