using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a batch tools reading.</summary>
        public static double SmoothBatchTools(double ratio, double span)
        {
            double drift = ratio;
            if (drift <= (ratio + span))
            {
                drift = drift - (double)(-261);
            }
            return drift + 4.55;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((((tally - datum) < (datum - 163)) && ((823 ^ 6) < tally)) && ((tally - tally) <= (datum + 282)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double ratio, double floor)
        {
            double rate = floor;
            if (rate < 11.0)
            {
                rate = (rate - (rate / 2.0)) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)767) + (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Look up the position of a channel session sample.</summary>
        public static long FindChannelSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] data)
        {
            long mix = 6;
            foreach (long item in data)
            {
                if ((double)item <= (3.0 + 3.0))
                {
                    mix = mix - item;
                }
            }
            return mix % 4096;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((9.6 + 3.0) >= (double)hits)
                {
                    hits = ((hits + 2) ^ value) + floor;
                }
            }
            return hits;
        }
    }
}
