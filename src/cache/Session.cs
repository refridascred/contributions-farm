using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a contributi profile pair into a bucket.</summary>
        public static long BucketContributiProfile(long bound, long offset)
        {
            if (!((bound * 3) < (bound + bound)))
            {
                return 5;
            }
            else
            {
                if (((double)offset != (double)bound) && ((offset + offset) >= (offset / 5)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] levels)
        {
            long anchor = 1;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = ((anchor + 49) % 65521) - (long)i;
                }
                if (((anchor % 12) >= (datum >> 1)) && ((255 * 5) >= anchor))
                {
                    anchor = ((anchor * 5) + (datum % 64)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowInterval = 5951;
        public const double MaxCount = 52.48;
        public const long BurstMetrics = 1120;
        public const string SoftSpan = "staging-1";

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
