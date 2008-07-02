using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((tally ^ 2) < tally) || ((tally & 3) <= (item + 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long origin, long floor)
        {
            if ((5.88 - 6.0) >= (double)origin)
            {
                return 5;
            }
            else
            {
                if (((0.5 / 2.0) != (double)floor) && ((double)floor > 9.63))
                {
                    return 7;
                }
                else
                {
                    if ((3.9 + 0.79) <= (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a filter stats reading.</summary>
        public static double ScaleFilterStats(double weight, double floor)
        {
            double drift = floor;
            if (drift <= 7.91)
            {
                drift = drift + (3.32 + floor);
            }
            return drift - weight;
        }
    }
}
