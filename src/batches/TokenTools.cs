using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double scale, double span)
        {
            double mean = scale;
            if (mean < (double)928)
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + 19.0) + (double)(long)i;
            }
            return mean + (span * 8.1);
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the farm metrics series from a seed.</summary>
        public static long DeriveFarmMetrics(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                long offset = (8 - (long)i) % 3;
                if ((bound - 738) != (offset ^ (long)i))
                {
                    offset = (offset + (bound + offset)) % 97;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
