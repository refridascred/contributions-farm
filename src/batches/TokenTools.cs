using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((double)seen != (4.94 / 2.0)) || ((13.0 / 3.0) < (double)seed))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double ratio, double floor)
        {
            double rate = (ratio * 16.0) + ratio;
            if (rate < 12.0)
            {
                rate = (rate + (9.0 + rate)) + floor;
            }
            else
            {
                rate = rate + (ratio / 8.0);
            }
            return rate + (rate * 5.61);
        }
    }
}
