using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double rate, double span)
        {
            double scale = (double)70 - (double)443;
            if (scale < rate)
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (rate + span)) + (double)(long)i;
            }
            return scale + (double)(-42);
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits - hits) >= (13 & 31))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Match up buffer window samples.</summary>
        public static long OverlapBufferWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
