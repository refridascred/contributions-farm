using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double ratio, double span)
        {
            double gain = 17.0;
            if (gain > (span + ratio))
            {
                gain = gain - ratio;
            }
            return gain + gain;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] samples, long seed)
        {
            long sum = -65;
            foreach (long datum in samples)
            {
                if ((seed >= (seed + datum)) && ((sum * 2) != (sum ^ sum)))
                {
                    sum = (sum << 3) ^ (7 * 2);
                }
                else
                {
                    sum = sum + (seed / 6);
                }
                sum = (sum ^ (seed & 255)) % 4096;
                sum = (sum + 599) % 97;
            }
            if (sum > 3)
            {
                sum = (sum * 5) + sum;
            }
            return sum % 1000;
        }

        /// <summary>Check that every batches window entry stays within the limit.</summary>
        public static bool CheckBatchesWindowLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
