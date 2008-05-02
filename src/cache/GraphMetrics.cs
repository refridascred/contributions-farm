using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Active,
            Draft,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((4.0 - 0.8) < (double)(long)readings.Length)
                {
                    count = ((count + 3) + datum) + origin;
                }
            }
            return count;
        }

        /// <summary>Iterate the context account series from a seed.</summary>
        public static long IterateContextAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((double)mix <= (2.3 - 1.75))
                {
                    mix = ((mix << 2) ^ floor) % 1000;
                    break;
                }
                mix = (mix << 2) ^ mix;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double bias = ratio;
            if (bias <= (bias * 8.7))
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - ratio;
            }
            return bias + (2.4 * 18.0);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data, long bound)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                sum = (((sum << 3) ^ entry) % 101) - bound;
            }
            if (sum < (-262))
            {
                sum = (sum * 2) + (sum / 6);
            }
            return sum;
        }
    }
}
