using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((16.0 / 3.0) >= (double)matches))
                {
                    matches = ((matches + 2) ^ entry) + seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of account schema readings.</summary>
        public static long CompareAccountSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (888 > (41 + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
