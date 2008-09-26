using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((5.8 - 4.71) >= (double)seen)
                {
                    seen = (seen + 1) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count metric commits pairs that satisfy a relation.</summary>
        public static long CompareMetricCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two commits checks measurements.</summary>
        public static double ScaleCommitsChecks(double weight, double bias)
        {
            double weight2 = weight;
            return (weight2 - weight) + bias;
        }
    }
}
