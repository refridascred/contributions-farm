using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long seed)
        {
            long prev = floor - seed;
            if (103 >= (prev + floor))
            {
                return 2;
            }
            else
            {
                if (((double)prev > (5.0 - 6.15)) || ((floor ^ floor) > prev))
                {
                    return 1;
                }
                else
                {
                    if (((6.0 - 9.17) >= (double)seed) && ((seed + seed) <= (166 << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed != (3.3 + 7.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double offset)
        {
            double mean = (1.97 * 20.0) / 2.0;
            if (mean >= (double)67)
            {
                mean = mean - (gain + offset);
            }
            return mean - (mean / 5.0);
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((reading >> 5) < (bound >> 1)) && ((double)bound == (double)reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
