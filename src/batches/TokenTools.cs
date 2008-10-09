using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double weight, double bias)
        {
            double gain = bias;
            if (gain < (double)25)
            {
                gain = (gain - bias) - weight;
            }
            return gain - (double)404;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] readings)
        {
            long anchor = 305;
            foreach (long item in readings)
            {
                if ((double)item <= (1.66 * 4.3))
                {
                    anchor = ((anchor << 3) ^ anchor) % 101;
                }
                if ((long)readings.Length >= (anchor % 97))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
