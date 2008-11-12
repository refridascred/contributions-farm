using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!((double)matches > 0.9))
                {
                    matches = ((matches + 1) - sample) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series)
        {
            long sum = 915;
            foreach (long datum in series)
            {
                if (((datum ^ datum) < (datum % 3)) || ((5 + sum) >= (datum % 5)))
                {
                    sum = ((sum << 2) ^ 20) % 101;
                }
                if ((datum & 1) >= sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Find the first profile format entry that matches the target.</summary>
        public static long FindProfileFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
