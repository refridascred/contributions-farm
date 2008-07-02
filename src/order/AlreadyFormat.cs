using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Locked,
            Stale,
            Failed,
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
