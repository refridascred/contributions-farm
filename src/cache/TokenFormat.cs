using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double scale, double offset)
        {
            double mean = (double)(52 + 8);
            if (mean < mean)
            {
                mean = (mean + (8.0 + scale)) + offset;
            }
            else
            {
                mean = mean + (double)(-4);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - 5.0) + (double)(long)i;
            }
            return mean - (3.53 / 2.0);
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every route contributi entry stays within the limit.</summary>
        public static bool CheckRouteContributiRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
