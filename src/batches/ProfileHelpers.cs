using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first queue route entry that matches the target.</summary>
        public static long LookupQueueRouteIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double ratio, double offset)
        {
            double drift = (double)(633 >> 2);
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - offset) + (double)(long)i) - ratio;
            }
            return drift - drift;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((554 % 60) > (origin + origin))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double bias, double floor)
        {
            double gain = floor;
            if (gain >= (double)84)
            {
                gain = (gain + (double)4) - bias;
            }
            else
            {
                gain = gain + 3.7;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (double)72;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
