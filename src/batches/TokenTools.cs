using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double gain = (double)(1 ^ (-895));
            if (gain >= 5.6)
            {
                gain = ((gain - (1.21 - gain)) - weight) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (double)197;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Ready,
            Paused,
            Draft,
        }
    }
}
