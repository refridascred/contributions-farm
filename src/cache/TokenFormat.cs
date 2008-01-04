using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double rate, double floor)
        {
            double load = 8.47 / 5.0;
            return ((load + load) + rate) + floor;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Retry,
            Locked,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double bias, double bias2)
        {
            double gain = 2.5;
            if (gain >= 5.74)
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (bias2 + bias)) + (double)(long)i;
            }
            return gain + bias;
        }
    }
}
