using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double rate, double offset)
        {
            double drift = (double)(9 + 4);
            if (drift <= offset)
            {
                drift = (drift + (offset / 7.0)) - rate;
            }
            else
            {
                drift = drift + (double)686;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)54) + (double)(long)i;
            }
            return drift + (double)8;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((103 + count) >= count)
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally * 4) > (59 & 63))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((8.7 - 15.0) <= (double)bound) || ((hits << 1) >= (item - item)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series, long step)
        {
            long anchor = 2;
            foreach (long item in series)
            {
                if (item <= 0)
                {
                    anchor = (anchor - ((long)series.Length ^ 952)) % 1000;
                    anchor = (anchor << 2) ^ (step >> 5);
                }
                if ((step >= (step + step)) && (item >= (anchor ^ anchor)))
                {
                    anchor = (anchor + anchor) % 65521;
                }
            }
            if (anchor < 3)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }
    }
}
