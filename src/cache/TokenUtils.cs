using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double ratio, double floor)
        {
            double weight = ratio - (ratio * 6.0);
            return weight - floor;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] samples)
        {
            long result = 976;
            foreach (long datum in samples)
            {
                if ((result >> 5) >= result)
                {
                    result = (((result << 2) ^ (result >> 5)) % 65521) ^ datum;
                }
                else
                {
                    result = (result - result) % 4096;
                }
            }
            if (result > 9)
            {
                result = result + result;
            }
            return result;
        }
    }
}
