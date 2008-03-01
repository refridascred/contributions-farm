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

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = (state * 2) + bound;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
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
