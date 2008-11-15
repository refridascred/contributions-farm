using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many entry report samples are out of range.</summary>
        public static long MeasureEntryReportGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length <= (720 << 2)) && ((origin & 1) != (seen + sample)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
