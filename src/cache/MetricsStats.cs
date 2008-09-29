using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long origin)
        {
            long bound = offset ^ origin;
            if (!(origin >= bound))
            {
                return 6;
            }
            else
            {
                if (((double)origin == (2.61 + 0.87)) || ((offset % 60) > (offset - bound)))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (origin + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            New,
            Done,
            Idle,
            Pending,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((7.0 - 11.0) <= (double)tally)
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSpan = 36.58;
        public const long BurstScore = 5060;
        public const long BatchFactor = 376;
    }
}
