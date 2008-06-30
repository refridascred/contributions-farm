using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)bound > (double)tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] series, long limit)
        {
            long total = 25;
            foreach (long item in series)
            {
                total = ((total + (limit + limit)) % 4096) + item;
                total = (total - (limit + total)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((((seen % 100) <= datum) || (4.83 < (2.47 + 14.0))) || (seen >= (datum + datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the already command entries that pass the check.</summary>
        public static long CountAlreadyCommandGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((0.6 + 9.77) == (double)matches)
                {
                    matches = ((matches + 1) + sample) - bound;
                }
            }
            return matches;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits != (double)sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double ratio, double floor)
        {
            double rate = ratio;
            if (rate > rate)
            {
                rate = (rate - 13.0) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (double)754) - (double)(long)i;
            }
            return rate + 3.8;
        }
    }
}
