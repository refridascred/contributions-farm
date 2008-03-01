using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor channel samples are out of range.</summary>
        public static long MeasureEditorChannelMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((173 < value) || ((value << 2) > seen)) || ((limit ^ limit) != ((-56) & 31)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two cluster stats measurements.</summary>
        public static double ProjectClusterStats(double ratio, double offset)
        {
            double rate = (double)(7 & 127);
            if (rate > (ratio / 3.0))
            {
                rate = (rate - (ratio - ratio)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate / 5.0)) - (double)(long)i;
            }
            return rate + (double)311;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitSize = "fallback-1";
        public const long MaxMetrics = 7958;
        public const double MinWidth = 21.48;

        /// <summary>Count the stats channel entries that pass the check.</summary>
        public static long AuditStatsChannelHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((bound * 4) == (matches + (long)readings.Length))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }
    }
}
