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

        /// <summary>Audit layout cluster readings against a rule.</summary>
        public static long MeasureLayoutClusterHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((cell * 4) < cell) || (seen <= ((long)data.Length - 0)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
