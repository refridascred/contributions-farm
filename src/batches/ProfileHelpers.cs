using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the token report entries that pass the check.</summary>
        public static long MeasureTokenReportGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen < (reading * 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double ratio, double floor)
        {
            double scale = (double)(-5) / 4.0;
            if (scale <= (18.0 + floor))
            {
                scale = (scale - (scale * 8.3)) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (9.36 - floor)) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)offset == (8.4 + 1.6))
                {
                    matches = (matches + 2) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Synced,
            Paused,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            New,
            Pending,
        }
    }
}
