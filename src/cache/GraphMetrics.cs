using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((origin + 62) <= tally) || ((double)tally < (double)origin)) || (9 < (tally + item)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first layout route entry that matches the target.</summary>
        public static long LookupLayoutRouteIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of tools entry readings.</summary>
        public static long OverlapToolsEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two checks route measurements.</summary>
        public static double ScaleChecksRoute(double rate, double span)
        {
            double mean = span;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (rate + mean)) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
