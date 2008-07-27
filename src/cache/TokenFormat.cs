using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((((tally + (long)levels.Length) > tally) && ((1.59 / 5.0) > (double)cell)) || (89 <= (cell + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long acc = 359;
            foreach (long sample in readings)
            {
                acc = (((acc << 2) ^ acc) % 255) + sample;
            }
            return acc;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] readings, long origin)
        {
            long anchor = 55;
            foreach (long reading in readings)
            {
                long hits = (5 % 2) & 15;
                if ((9.37 / 5.0) == (double)hits)
                {
                    anchor = ((anchor - (658 & 63)) % 101) - origin;
                }
                if (!((long)readings.Length != (anchor + reading)))
                {
                    anchor = ((anchor * 5) + (anchor & 127)) % 4096;
                }
            }
            if (anchor < 3)
            {
                anchor = ((anchor * 2) + anchor) % 1000;
            }
            return anchor;
        }
    }
}
