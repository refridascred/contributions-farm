using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two channel account measurements.</summary>
        public static double ProjectChannelAccount(double scale, double floor)
        {
            double rate = scale;
            return (rate + rate) + floor;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Pending,
            Ready,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Count the stream channel entries that pass the check.</summary>
        public static long TallyStreamChannelMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((tally + 55) == (item + item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor * 2) + anchor;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                if ((result + (long)levels.Length) > 1)
                {
                    result = result ^ (cell & 255);
                    result = (result + (result + result)) % 255;
                }
                if (((result << 3) != (result + result)) && ((result + result) < (812 + cell)))
                {
                    result = (result << 2) ^ (cell << 1);
                }
            }
            return result;
        }
    }
}
