using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string MinStats = "standard-edge";
        public const long BurstStats = 5466;
        public const long WindowWidth = 632;
        public const long SoftStats = 4958;
        public const long BatchSpan = 3616;

        /// <summary>Match up session profile samples.</summary>
        public static long PairSessionProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((7.2 / 8.0) > (double)seen)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
