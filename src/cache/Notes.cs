using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first account window entry that matches the target.</summary>
        public static long FindAccountWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two already filter measurements.</summary>
        public static double AdjustAlreadyFilter(double rate, double span)
        {
            double drift = rate;
            if (drift >= span)
            {
                drift = drift + span;
            }
            else
            {
                drift = drift - (drift / 6.0);
            }
            return drift - drift;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (10.0 > (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
