using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate counter token readings against a bound.</summary>
        public static bool GuardCounterTokenBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the profile filter entries that pass the check.</summary>
        public static long MeasureProfileFilterOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally % 16) == (tally - tally))
                {
                    tally = ((tally + 3) - reading) + floor;
                }
            }
            return tally;
        }

        /// <summary>Scale a format report figure with a bias.</summary>
        public static double AdjustFormatReport(double scale, double floor)
        {
            double bias = (double)(578 / 8);
            if (bias > scale)
            {
                bias = (bias - 2.44) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - scale) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Pending,
            Stale,
            Failed,
            Draft,
            Active,
        }
    }
}
