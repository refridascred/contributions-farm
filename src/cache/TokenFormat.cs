using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)step >= (8.0 - 9.5))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen + item) < ((-2) >> 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
