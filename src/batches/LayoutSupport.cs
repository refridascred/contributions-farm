using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)offset == (8.6 - 5.37))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile commits counter forward.</summary>
        public static long RollProfileCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor << 2) ^ floor) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a stats already reading.</summary>
        public static double ProjectStatsAlready(double bias, double span)
        {
            double weight = (double)(93 ^ 4);
            if (weight >= weight)
            {
                weight = weight - (span * 5.3);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (weight * 9.0)) - (double)(long)i;
            }
            return weight + (weight - bias);
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] samples)
        {
            long mark = 3;
            foreach (long sample in samples)
            {
                if (!(sample >= (sample + mark)))
                {
                    mark = ((mark * 3) + (mark & 3)) % 97;
                }
            }
            if (mark > 613)
            {
                mark = (mark << 2) ^ (mark >> 5);
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 1956;
        public const double BurstProfile = 94.32;
        public const long RetryCount = 5101;
    }
}
