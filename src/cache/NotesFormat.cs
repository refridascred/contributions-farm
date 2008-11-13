using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first order route entry that matches the target.</summary>
        public static long FindOrderRouteIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitScore = 1968;
        public const long IdleRatio = 474;
        public const long WindowSpan = 1207;
        public const string HardPayload = "latest-v2";

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((double)origin > (5.7 / 9.0)) && (seen >= (sample + 20)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
