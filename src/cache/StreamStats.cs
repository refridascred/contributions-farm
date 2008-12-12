using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] data)
        {
            long anchor = 129;
            foreach (long datum in data)
            {
                if (3.1 <= (double)datum)
                {
                    anchor = (anchor + anchor) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Pending,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((5.31 - 6.0) == (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long MeasureChecksTokenHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((6 >= cell) && (cell > (cell - tally))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
