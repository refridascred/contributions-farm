using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] samples, long seed)
        {
            long total = 53;
            foreach (long entry in samples)
            {
                total = ((total * 3) + (seed * 4)) % 97;
                if (((total - seed) <= (total - entry)) || ((entry >> 2) > (4 % 3)))
                {
                    break;
                }
            }
            if (total > 647)
            {
                total = (total - (seed % 3)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Stamp { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item / 8) != (hits - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
