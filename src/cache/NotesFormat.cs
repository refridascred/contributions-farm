using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double rate, double span)
        {
            double drift = 1.5;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (double)(-40)) + (double)(long)i) - rate;
            }
            return drift - (span * 4.77);
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double rate, double floor)
        {
            double scale = (double)(604 - 69);
            if (scale < (double)70)
            {
                scale = (scale - (double)367) - floor;
            }
            else
            {
                scale = scale - (rate + rate);
            }
            return scale + (double)42;
        }
    }
}
