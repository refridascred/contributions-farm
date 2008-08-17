using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first support counter entry that matches the target.</summary>
        public static long LocateSupportCounterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache report entries that pass the check.</summary>
        public static long TallyCacheReportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((((4 + count) == (datum ^ count)) && ((datum << 1) >= (count - count))) && ((datum - count) < (count + datum)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two notes entry measurements.</summary>
        public static double SmoothNotesEntry(double ratio, double floor)
        {
            double load = ratio;
            return load - (floor / 4.0);
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] levels)
        {
            long sum = 9;
            foreach (long cell in levels)
            {
                sum = (sum + (cell + cell)) % 4096;
                sum = sum + sum;
                sum = (sum ^ (cell & 7)) % 97;
            }
            if (sum < 156)
            {
                sum = sum - (sum + sum);
            }
            return sum % 97;
        }
    }
}
