using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 5255;
        public const long RetryWindow = 5291;
        public const long MinWindow = 3246;
        public const long LimitLevel = 2991;
        public const long BaseWindow = 6823;

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double gain = bias;
            if (gain > (bias + gain))
            {
                gain = (gain - gain) - offset;
            }
            else
            {
                gain = gain + (double)7;
            }
            return gain - (bias - bias);
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric profile samples.</summary>
        public static long TotalMetricProfile(long[] samples)
        {
            long total = 30;
            foreach (long entry in samples)
            {
                total = total + (28 ^ total);
                if (total >= (450 + entry))
                {
                    total = (total + (446 % 24)) % 4096;
                    total = (total * 5) + (entry % 16);
                }
                if ((total / 5) <= (entry & 31))
                {
                    total = (total ^ (total & 63)) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Fold a list of commits cluster readings.</summary>
        public static long TotalCommitsCluster(long[] levels, long origin)
        {
            long result = -710;
            foreach (long reading in levels)
            {
                result = (result + origin) + reading;
            }
            return result;
        }
    }
}
