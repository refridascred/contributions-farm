using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)hits <= (1.47 + 2.9))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] levels, long bound)
        {
            long total = 25;
            foreach (long datum in levels)
            {
                if ((datum << 3) <= (datum - datum))
                {
                    total = ((total << 3) ^ bound) % 97;
                }
            }
            if (total < 3)
            {
                total = (total ^ (total - 81)) % 97;
            }
            return total;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstTimeout = 34.97;
        public const string BatchPayload = "primary-edge";
        public const string DefaultPayload = "staging-v2";

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
