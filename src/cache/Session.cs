using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long origin, long seed)
        {
            long edge = origin - seed;
            if ((origin << 1) <= (4 * 2))
            {
                return 4;
            }
            else
            {
                if (seed >= edge)
                {
                    return 0;
                }
                else
                {
                    if ((origin > (edge % 16)) && ((seed - (-90)) >= origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((bound + tally) < datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetrySpan = 9840;
        public const string BaseContributi = "latest-1";
        public const long CacheContributi = 6713;

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double weight, double bias)
        {
            double rate = 4.57;
            if (rate > (bias * 4.01))
            {
                rate = (rate + rate) - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (bias + bias)) - (double)(long)i;
            }
            return rate + rate;
        }
    }
}
