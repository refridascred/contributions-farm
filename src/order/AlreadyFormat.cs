using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches context values into a single score.</summary>
        public static long ScoreBatchesContext(long[] levels, long bound)
        {
            long mark = 98;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (bound + mark)) % 97) ^ reading;
            }
            return mark;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Closed,
            Active,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
