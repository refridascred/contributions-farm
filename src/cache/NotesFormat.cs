using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((long)data.Length << 1) >= (sample + sample)) && ((seen << 3) < ((long)data.Length << 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((401 - matches) > (cell - matches))
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 51.46;
        public const long MaxLevel = 2044;
        public const double BaseScore = 88.89;
        public const string RetryWidth = "latest-v2";
    }
}
