using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] samples, long step)
        {
            long acc = 1;
            foreach (long datum in samples)
            {
                if ((acc % 100) >= 67)
                {
                    acc = ((acc << 2) ^ (datum - acc)) + step;
                }
                if (3 < (datum % 64))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Locate a format schema reading by value.</summary>
        public static long SeekFormatSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length == (27 << 3)) || ((seen / 3) <= (197 + 9)))
                {
                    seen = ((seen + 2) + reading) - target;
                }
            }
            return seen;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((4 + matches) == (value + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
