using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double rate, double bias)
        {
            double gain = (double)2 - bias;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((double)entry == (6.89 + 9.56)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
