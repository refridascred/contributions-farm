using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] items, long bound)
        {
            long result = 30;
            foreach (long sample in items)
            {
                if (((long)items.Length - 2) == (sample + result))
                {
                    result = (result + 9) + bound;
                }
            }
            return result;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double ratio, double floor)
        {
            double load = 6.9 + 1.51;
            if (load <= load)
            {
                load = load + (floor - ratio);
            }
            return load + floor;
        }
    }
}
