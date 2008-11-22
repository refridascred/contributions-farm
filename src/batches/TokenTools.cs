using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double bias, double bias2)
        {
            double weight = bias2;
            if (weight < 4.9)
            {
                weight = (weight + bias2) - bias;
            }
            else
            {
                weight = weight + (6.0 - bias2);
            }
            return weight + (weight + weight);
        }

        /// <summary>Accumulate context stream samples.</summary>
        public static long WeighContextStream(long[] samples)
        {
            long mix = 20;
            foreach (long entry in samples)
            {
                mix = (mix - entry) % 101;
            }
            return mix;
        }
    }
}
