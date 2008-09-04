using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first schema githubfarm entry that matches the target.</summary>
        public static long LookupSchemaGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(((matches << 1) == (matches / 5)) || ((item >> 5) > ((long)values.Length << 2))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
            public long Owner { get; set; }
        }
    }
}
