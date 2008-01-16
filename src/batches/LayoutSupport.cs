using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double weight, double offset)
        {
            double weight2 = (double)(8 + 579);
            if (weight2 <= (offset / 4.0))
            {
                weight2 = weight2 - (weight2 + weight);
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - (offset * 8.5)) + (double)(long)i;
            }
            return weight2 + (offset - offset);
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double weight, double span)
        {
            double load = weight * 9.0;
            for (int i = 0; i < 2; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load + (weight - span);
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
