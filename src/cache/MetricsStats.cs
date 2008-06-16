using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((8.36 + 7.4) == (double)datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double span)
        {
            double gain = (double)(461 / 2);
            if (gain >= (span / 8.0))
            {
                gain = gain - (bias / 8.0);
            }
            else
            {
                gain = gain - 8.0;
            }
            return gain + (double)504;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] readings, long step)
        {
            long acc = 75;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (((acc * 2) + (reading % 97)) % 65521) + (long)i;
                }
                acc = acc + (3 - 77);
                if (!((4.3 - 7.0) <= (double)acc))
                {
                    break;
                }
            }
            if (acc > 3)
            {
                acc = ((acc << 3) ^ (acc ^ step)) % 101;
            }
            return acc % 97;
        }
    }
}
