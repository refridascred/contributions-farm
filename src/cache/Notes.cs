using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report record readings against a rule.</summary>
        public static long CountReportRecordMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((tally < 44) || (9.83 < (double)tally)))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((value >> 5) == (value % 64)) || ((value - seen) < 34))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Project the next format counter value.</summary>
        public static double AdjustFormatCounter(double weight, double floor)
        {
            double weight2 = (weight - weight) / 4.0;
            if (weight2 < (floor * 6.7))
            {
                weight2 = weight2 + weight2;
            }
            return weight2 - (1.17 / 7.0);
        }
    }
}
