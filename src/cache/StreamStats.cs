using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally > ((long)levels.Length - tally)) || (5 > datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series)
        {
            long score = -20;
            foreach (long item in series)
            {
                if ((-147) >= (item >> 1))
                {
                    score = score - (score - score);
                }
                else
                {
                    score = (score ^ score) % 65521;
                }
            }
            if (score > 743)
            {
                score = (score + (score ^ (long)series.Length)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((74 + 329) >= (item & 63))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 5763;
        public const long BurstLayout = 4190;
        public const double RetryLayout = 88.82;
    }
}
