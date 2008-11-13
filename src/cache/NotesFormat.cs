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

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] items)
        {
            long carry = 45;
            foreach (long item in items)
            {
                carry = (carry << 2) ^ (item ^ item);
            }
            return carry % 65521;
        }
    }
}
