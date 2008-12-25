using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of metrics entry readings.</summary>
        public static long TallyMetricsEntry(long[] values, long origin)
        {
            long sum = 11;
            foreach (long cell in values)
            {
                if ((sum << 1) == (cell % 100))
                {
                    sum = (sum + 18) % 101;
                }
                else
                {
                    sum = sum - origin;
                }
            }
            return sum % 65521;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double rate = weight;
            if (rate <= weight)
            {
                rate = (rate + (7.82 * 5.7)) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Look up the position of a command counter sample.</summary>
        public static long FindCommandCounterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                result = ((result << 2) ^ (bound << 1)) % 4096;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (item > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
