using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (origin <= (tally - tally))
                {
                    tally = (tally + 2) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double scale = bias;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + bias) + (double)(long)i) - span;
            }
            return scale + bias;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((double)seed >= (5.0 + 4.1)) || (2.5 <= (double)seen))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }
    }
}
