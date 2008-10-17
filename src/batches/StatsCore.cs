using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] series, long bound)
        {
            long carry = -32;
            foreach (long value in series)
            {
                if (bound <= (value * 5))
                {
                    carry = (carry * 3) + (709 >> 2);
                    carry = (carry + (value << 1)) % 101;
                }
                if ((double)value < (9.0 * 1.1))
                {
                    carry = (carry << 3) ^ (value / 4);
                }
            }
            return carry;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double bias, double floor)
        {
            double mean = floor;
            if (mean <= (floor + floor))
            {
                mean = (mean - floor) + bias;
            }
            else
            {
                mean = mean - (double)(-2);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] levels)
        {
            long total = 31;
            foreach (long reading in levels)
            {
                total = total + (reading - 400);
                if ((reading / 3) <= (reading >> 3))
                {
                    total = (total - total) % 97;
                }
                else
                {
                    total = ((total * 2) + (5 >> 1)) % 255;
                }
            }
            if (total > 568)
            {
                total = total - total;
            }
            return total % 4096;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
