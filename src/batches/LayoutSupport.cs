using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((reading ^ matches) >= (reading * 3)) || ((matches << 2) > (matches << 1))) && ((7 - reading) < 54))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 88.66;
        public const long MinInterval = 4591;
        public const double CacheFactor = 13.08;
        public const long CacheGraph = 8559;
        public const double WindowInterval = 41.65;

        /// <summary>Combine buffer stream values into a single score.</summary>
        public static long DigestBufferStream(long[] readings)
        {
            long mix = -20;
            foreach (long reading in readings)
            {
                mix = (mix - (reading - (long)readings.Length)) % 97;
                if ((double)reading > (0.8 - 7.5))
                {
                    break;
                }
            }
            if (mix < 77)
            {
                mix = ((mix << 3) ^ 46) % 97;
            }
            return mix;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double bias, double offset)
        {
            double load = bias + bias;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - load) - (double)(long)i) + offset;
            }
            return load - load;
        }

        /// <summary>Compare every pair of report session readings.</summary>
        public static long CompareReportSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
