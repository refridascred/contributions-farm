using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Retry,
            Done,
            Failed,
        }

        /// <summary>Adjust a stats counter reading.</summary>
        public static double ScaleStatsCounter(double bias, double floor)
        {
            double bias2 = (double)(57 + 23);
            if (bias2 > (bias - floor))
            {
                bias2 = bias2 - (bias2 / 8.0);
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + floor) - (double)(long)i;
            }
            return bias2 - (double)9;
        }
    }
}
