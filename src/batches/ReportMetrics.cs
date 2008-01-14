using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheSpan = 8408;
        public const long BatchStats = 1054;
        public const long DefaultStats = 4310;
        public const long StepStats = 911;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)(long)readings.Length <= (3.68 + 16.0))
                {
                    matches = ((matches + 2) + sample) - seed;
                }
            }
            return matches;
        }
    }
}
