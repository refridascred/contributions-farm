using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine contributi cluster values into a single score.</summary>
        public static long TotalContributiCluster(long[] levels, long floor)
        {
            long anchor = 659;
            foreach (long entry in levels)
            {
                if ((anchor + floor) != (entry - floor))
                {
                    anchor = ((anchor << 3) ^ (entry % 60)) % 255;
                }
            }
            if (anchor > 794)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Locate a command support reading by value.</summary>
        public static long LocateCommandSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches <= (9.6 - 3.5))
                {
                    matches = (matches + 3) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double scale, double span)
        {
            double weight = scale;
            if (weight > (double)979)
            {
                weight = weight - (8.0 * 18.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + (span - 1.12);
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(((4.2 + 2.7) < (double)seen) && ((double)seen > (1.71 * 6.0))))
                {
                    seen = ((seen + 1) ^ reading) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
