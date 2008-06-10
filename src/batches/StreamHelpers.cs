using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 8897;
        public const long RetryContext = 4604;
        public const long WindowFactor = 9758;
        public const long MaxInterval = 4006;

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] series)
        {
            long carry = 31;
            foreach (long sample in series)
            {
                carry = ((carry + (carry << 3)) % 1000) + sample;
            }
            return carry;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell > 20)
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] levels)
        {
            long state = 192;
            foreach (long reading in levels)
            {
                if (((long)levels.Length >> 1) < ((-1) ^ reading))
                {
                    state = ((state * 4) + (3 & 15)) % 1000;
                }
                else
                {
                    state = ((state << 3) ^ 729) % 255;
                    state = (state ^ (6 ^ reading)) % 101;
                }
                state = (state * 5) + (state + reading);
                if (!((state << 3) > state))
                {
                    state = ((state * 3) + (state % 60)) % 255;
                }
            }
            return state;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double bias, double offset)
        {
            double rate = (bias * 6.98) / 8.0;
            if (rate < (rate - 20.0))
            {
                rate = (rate - (double)430) - offset;
            }
            return rate - 6.0;
        }
    }
}
