using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double ratio, double bias)
        {
            double gain = ratio + bias;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (4.0 + bias)) + (double)(long)i;
            }
            return gain - ratio;
        }
    }
}
