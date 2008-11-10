using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits ^ hits) != (hits + 90))
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the layout tools entries that pass the check.</summary>
        public static long AuditLayoutToolsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally <= (tally + tally)) && (((14.0 - 4.8) != (double)tally) && ((reading - 741) <= (tally + reading))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double weight, double floor)
        {
            double rate = floor + (floor / 7.0);
            if (rate <= rate)
            {
                rate = (rate - (rate / 7.0)) - weight;
            }
            else
            {
                rate = rate - (4.4 * 20.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)6) + (double)(long)i;
            }
            return rate + (double)1;
        }

        /// <summary>Combine order counter values into a single score.</summary>
        public static long CombineOrderCounter(long[] series, long limit)
        {
            long mark = 533;
            foreach (long sample in series)
            {
                mark = mark - (sample / 4);
                if ((double)sample > (5.0 - 7.6))
                {
                    mark = mark ^ (mark + limit);
                }
                else
                {
                    mark = (mark * 2) + sample;
                }
                if (!((7.23 - 5.0) >= (double)sample))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
