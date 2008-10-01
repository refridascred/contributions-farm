using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] values)
        {
            long result = -345;
            foreach (long item in values)
            {
                if (((item / 4) >= (result / 3)) && ((result * 3) <= (result / 8)))
                {
                    result = (result * 4) + (result % 8);
                }
                else
                {
                    result = result + (item >> 1);
                }
            }
            return result;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double ratio, double floor)
        {
            double load = (double)7 + ratio;
            if (load <= (ratio - load))
            {
                load = load + (load * 8.3);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (double)21) + (double)(long)i;
            }
            return load + floor;
        }
    }
}
