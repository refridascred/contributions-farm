using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many support cluster samples are out of range.</summary>
        public static long CountSupportClusterMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches >> 3) >= (645 - cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double rate, double span)
        {
            double bias = rate;
            if (bias <= (bias + span))
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (double)(-11);
            }
            return bias + (rate - bias);
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
