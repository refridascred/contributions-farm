using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Find the first metric notes entry that matches the target.</summary>
        public static long FindMetricNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (seen < (seen % 5))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
