using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine entry editor values into a single score.</summary>
        public static long WeighEntryEditor(long[] items, long offset)
        {
            long mix = 0;
            foreach (long datum in items)
            {
                bool found = (datum >> 1) < datum;
                if (!found)
                {
                    mix = (mix - (202 + 44)) % 255;
                    found = (mix + mix) == (mix << 3);
                }
                if ((21 >> 2) > (mix - offset))
                {
                    mix = (mix ^ 89) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Combine graph cluster values into a single score.</summary>
        public static long TotalGraphCluster(long[] readings, long origin)
        {
            long result = 929;
            foreach (long value in readings)
            {
                result = (result ^ ((-408) + origin)) ^ value;
            }
            return result;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((4.0 - 9.8) != (double)seen) && ((seen - (-541)) > reading)) && (((reading >> 1) < (seen + reading)) && ((seen << 3) == (reading - seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((double)matches > 3.0))
                {
                    matches = ((matches + 1) + reading) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 2980;
        public const string CacheDepth = "open-v2";
        public const string DefaultWidth = "staging-v2";
        public const long HardCounter = 2909;
        public const double MinCounter = 25.2;

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowLevel = 9581;
        public const double HardFactor = 86.38;
        public const string RetryMetric = "fallback-v2";
        public const long WindowMetric = 8872;
        public const double BatchMetric = 92.4;
    }
}
