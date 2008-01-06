using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double rate, double floor)
        {
            double bias = (double)(7 * 2);
            if (bias > bias)
            {
                bias = bias - (bias - rate);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (rate + bias)) + (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (offset > (count - offset))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)tally > (double)7)
                {
                    tally = ((tally + 1) + entry) - offset;
                }
            }
            return tally;
        }
    }
}
