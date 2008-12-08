using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings, long origin)
        {
            long sum = 7;
            foreach (long item in readings)
            {
                if ((item >= (origin >> 3)) || ((origin & 3) < (origin ^ item)))
                {
                    sum = ((sum << 3) ^ (94 - sum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
