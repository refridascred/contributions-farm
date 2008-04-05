using System;

namespace Common.Utilities
{
    /// <summary>Report checks helpers.</summary>
    public static class ReportChecks
    {
        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double ratio, double span)
        {
            double scale = 9.58;
            if (scale >= scale)
            {
                scale = (scale - 2.0) + ratio;
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (13.0 * 7.0)) + (double)(long)i;
            }
            return scale + (double)26;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!(9.78 < (double)value) && ((hits + value) <= value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits / 8) <= (765 % 64))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of account entry readings.</summary>
        public static long PairAccountEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double gain, double floor)
        {
            double rate = gain * 2.0;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate - (rate * 2.4)) + (double)(long)i) - floor;
            }
            return rate - rate;
        }
    }
}
