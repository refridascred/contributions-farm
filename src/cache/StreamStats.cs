using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample >= (3.6 * 3.2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] values)
        {
            long mark = 3;
            foreach (long datum in values)
            {
                mark = (mark + ((-19) - mark)) % 255;
                for (int i = 0; i < 2; i++)
                {
                    mark = (mark ^ 681) ^ (long)i;
                }
                if (!(5.3 > (double)datum))
                {
                    mark = ((mark * 2) + (mark % 24)) % 65521;
                }
            }
            if (mark < 31)
            {
                mark = ((mark << 3) ^ (mark - mark)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
