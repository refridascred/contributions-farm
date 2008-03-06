using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] levels, long step)
        {
            long sum = -86;
            foreach (long datum in levels)
            {
                if ((sum / 5) >= (datum - datum))
                {
                    sum = ((sum << 3) ^ sum) - step;
                }
                sum = ((sum << 3) ^ (70 & 3)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double rate, double offset)
        {
            double mean = (double)750 * 19.0;
            if (mean > rate)
            {
                mean = mean + (double)254;
            }
            else
            {
                mean = mean + 16.0;
            }
            return mean - (offset + mean);
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            New,
            Dropped,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] series)
        {
            long total = 557;
            foreach (long reading in series)
            {
                if ((reading + 973) < reading)
                {
                    total = (total ^ (reading * 4)) % 101;
                }
            }
            return total;
        }
    }
}
