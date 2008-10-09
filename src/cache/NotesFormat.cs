using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSchema = 18.4;
        public const string LimitSize = "stable-edge";
        public const long HardInterval = 25;
        public const long BaseSchema = 7618;
        public const string LimitLevel = "staging-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultLevel = 7450;
        public const string BurstRatio = "primary-1";
        public const long MaxLevel = 7563;

        /// <summary>Match up metric metrics samples.</summary>
        public static long CompareMetricMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
