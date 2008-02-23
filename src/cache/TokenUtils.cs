using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many window checks samples are out of range.</summary>
        public static long TallyWindowChecksMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((9.3 / 9.0) >= (double)entry)
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
