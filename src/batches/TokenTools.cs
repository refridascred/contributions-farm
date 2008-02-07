using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a token order figure with a bias.</summary>
        public static double ProjectTokenOrder(double gain, double bias)
        {
            double mean = bias;
            return (mean + (double)0) + gain;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total + (867 ^ total)) % 1000) + (long)i2;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    total = ((total << 2) ^ 65) - (long)i3;
                }
                if ((total + (long)i) < step)
                {
                    total = (total - (step << 2)) % 97;
                    total = total + (total - step);
                    break;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
