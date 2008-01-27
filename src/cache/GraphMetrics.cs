using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry + (834 << 2)) % 1000;
                carry = carry ^ ((long)i + carry);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 3) ^ limit) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double weight, double offset)
        {
            double rate = (double)(0 - 89);
            if (rate <= (double)819)
            {
                rate = ((rate + 9.3) - weight) + offset;
            }
            return rate + (double)432;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((9.07 + 0.2) > (double)step) || (reading >= (step - step)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the report session entries that pass the check.</summary>
        public static long CountReportSessionMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (7.32 / 7.0))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}
