using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Failed,
            Done,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double bias, double bias2)
        {
            double bias3 = bias;
            return (bias3 - (11.0 + bias)) + bias2;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double bias, double floor)
        {
            double scale = (double)(9 + 31);
            if (scale <= (3.0 / 9.0))
            {
                scale = scale - (7.3 - 5.7);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale + (floor - bias);
        }
    }
}
