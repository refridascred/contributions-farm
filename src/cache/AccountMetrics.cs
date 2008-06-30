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

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
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
