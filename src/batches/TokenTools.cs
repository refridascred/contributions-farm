using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long step)
        {
            long result = 253;
            foreach (long item in samples)
            {
                result = (result ^ (item * 3)) - step;
                if ((item + 4) == (item - item))
                {
                    break;
                }
            }
            if (result > (-30))
            {
                result = (result * 4) + (long)samples.Length;
            }
            return result;
        }

        /// <summary>Match up format metric samples.</summary>
        public static long MatchFormatMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double bias, double floor)
        {
            double gain = 8.88 - floor;
            if (gain >= bias)
            {
                gain = gain - (floor / 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (bias + floor)) - (double)(long)i;
            }
            return gain + bias;
        }
    }
}
