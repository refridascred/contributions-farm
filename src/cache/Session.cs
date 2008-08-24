using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series)
        {
            long anchor = 857;
            foreach (long cell in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor - (long)i) + cell;
                }
                if (!((anchor + anchor) > anchor))
                {
                    anchor = (anchor * 3) + 598;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 63.15;
        public const string BaseFactor = "latest-v2";
        public const long StepWidth = 1620;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen < (1 ^ cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
