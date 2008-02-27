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

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
