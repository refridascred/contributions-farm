using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample == (double)29)
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Level { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Failed,
            Synced,
            Draft,
        }
    }
}
