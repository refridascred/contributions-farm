using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MinSize = 66.86;
        public const long MinMetric = 60;
        public const long BurstLevel = 8536;
        public const string MaxMetric = "strict-v2";

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
