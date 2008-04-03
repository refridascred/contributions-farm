using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 >= (scale2 * 3.3))
            {
                scale2 = scale2 - 6.62;
            }
            else
            {
                scale2 = scale2 - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 + 3.8;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate githubfarm metric readings against a bound.</summary>
        public static bool ValidateGithubfarmMetricLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits == (double)56)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }
    }
}
