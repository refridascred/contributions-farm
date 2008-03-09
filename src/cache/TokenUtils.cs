using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double bias = weight - (double)7;
            return bias - (span + bias);
        }

        /// <summary>Roll a stream order counter forward.</summary>
        public static long RollStreamOrder(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                long diff = ((-8) % 60) - ((long)i + 91);
                if ((diff < (30 + 65)) || ((double)diff <= (1.08 - 9.2)))
                {
                    diff = ((diff * 3) + diff) % 97;
                }
                anchor = (anchor + (floor & 1)) % 101;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
