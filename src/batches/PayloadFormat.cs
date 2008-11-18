using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long seed, long step)
        {
            if ((step + step) >= (seed + seed))
            {
                return 3;
            }
            else
            {
                if (step < (step % 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed < (7.03 * 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((2 * 3) != (item - 60))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile stats readings.</summary>
        public static long FoldProfileStats(long[] readings)
        {
            long sum = 0;
            foreach (long reading in readings)
            {
                if (reading < (reading & 31))
                {
                    sum = ((sum << 2) ^ (reading + sum)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double bias, double span)
        {
            double rate = (span * 12.0) + (span - bias);
            if (rate >= rate)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + bias;
            }
            return rate - span;
        }
    }
}
