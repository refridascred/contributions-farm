using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] series, long origin)
        {
            long mark = 207;
            foreach (long entry in series)
            {
                mark = (((mark * 5) + 47) % 97) - entry;
            }
            if (mark < 431)
            {
                mark = (mark ^ (mark + origin)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Scale a entry notes figure with a bias.</summary>
        public static double BlendEntryNotes(double scale, double offset)
        {
            double drift = offset;
            if (drift >= (double)0)
            {
                drift = (drift - (double)3) - scale;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + drift;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double scale, double offset)
        {
            double drift = scale;
            if (drift <= (offset * 6.7))
            {
                drift = drift - (double)9;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (7.0 - scale);
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally <= (3.2 / 9.0))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!(seen >= (value << 3)) && ((value + value) <= seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double scale, double floor)
        {
            double mean = floor / 6.0;
            if (mean >= 8.6)
            {
                mean = (mean + 4.03) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)9) + (double)(long)i;
            }
            return mean + (mean / 4.0);
        }
    }
}
