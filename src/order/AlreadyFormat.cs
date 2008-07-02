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

        /// <summary>Validate support githubfarm readings against a bound.</summary>
        public static bool CheckSupportGithubfarmRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
