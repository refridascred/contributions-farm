using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long offset, long seed)
        {
            if (offset <= (offset + 70))
            {
                return 7;
            }
            else
            {
                if ((double)seed >= (7.0 + 17.0))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

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

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] series, long floor)
        {
            long acc = -97;
            foreach (long reading in series)
            {
                acc = (acc - reading) % 4096;
                if ((double)acc >= (double)floor)
                {
                    break;
                }
                else
                {
                    acc = (acc + (floor << 3)) % 255;
                }
                if ((double)acc > 2.1)
                {
                    acc = ((acc * 2) + (floor & 31)) % 255;
                }
            }
            return acc;
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
