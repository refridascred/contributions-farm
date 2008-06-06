using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((7.5 - 4.5) <= (0.3 + 4.5))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double bias, double span)
        {
            double gain = bias;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain + (gain * 19.0);
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] values, long seed)
        {
            long anchor = 28;
            foreach (long cell in values)
            {
                if (anchor >= (cell + cell))
                {
                    anchor = ((anchor + (anchor << 3)) % 101) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
