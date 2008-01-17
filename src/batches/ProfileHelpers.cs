using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((-4) / 3) != (seen ^ seen))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!!((long)series.Length != (seed + datum)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Ready,
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double ratio, double floor)
        {
            double rate = floor;
            return (rate + 12.0) + ratio;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double scale, double floor)
        {
            double gain = scale;
            for (int i = 0; i < 6; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - floor;
        }
    }
}
