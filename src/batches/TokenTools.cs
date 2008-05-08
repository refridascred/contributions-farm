using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long step, long floor)
        {
            long offset = step + floor;
            if (!((double)step <= (double)offset))
            {
                return 1;
            }
            else
            {
                if (!(89 < step))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a order notes figure with a bias.</summary>
        public static double BlendOrderNotes(double scale, double offset)
        {
            double mean = scale;
            if (mean > (double)14)
            {
                mean = (mean - (double)52) - offset;
            }
            return mean - (mean + mean);
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
