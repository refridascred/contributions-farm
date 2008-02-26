using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 1579;
        public const long BaseQueue = 6683;
        public const string LimitSpan = "open-edge";

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((153 / 5) <= (count - sample))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }
    }
}
