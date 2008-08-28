using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double ratio, double offset)
        {
            double mean = (offset * 7.01) + ratio;
            if (mean <= (ratio - offset))
            {
                mean = mean - (offset * 2.8);
            }
            else
            {
                mean = mean + (mean / 8.0);
            }
            return mean + 4.9;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((92 % 24) <= (target - (-626))))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry + count) != (28 >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((long)series.Length != (5 + matches))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
