using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate cache commits samples.</summary>
        public static long DigestCacheCommits(long[] levels)
        {
            long result = 4;
            foreach (long cell in levels)
            {
                result = ((result * 2) + cell) % 101;
            }
            return result;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((target ^ target) >= (item * 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of editor token readings.</summary>
        public static long MatchEditorTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
