using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading < (reading + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank already record input into a small class.</summary>
        public static long SortAlreadyRecord(long origin, long limit)
        {
            if ((33 - limit) >= limit)
            {
                return 8;
            }
            else
            {
                if ((5.18 / 7.0) == (double)limit)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double ratio, double span)
        {
            double drift = (ratio / 3.0) - (double)28;
            return (drift - (double)972) + span;
        }
    }
}
