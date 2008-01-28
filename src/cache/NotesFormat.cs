using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 5981;
        public const long MaxWidth = 1390;
        public const double BurstWindow = 8.12;
        public const long MaxWindow = 8587;

        /// <summary>Define payload limits and defaults.</summary>
        public const string CachePayload = "standard-1";
        public const long BasePayload = 6245;
        public const long IdlePayload = 1242;
        public const long DefaultPayload = 1198;
        public const long StepPayload = 2210;
    }
}
