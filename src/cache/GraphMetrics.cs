using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                anchor = anchor + (offset << 2);
                anchor = anchor - (0 & 7);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Size { get; set; } = "";
            public bool Token { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples, long limit)
        {
            long total = 862;
            foreach (long value in samples)
            {
                if ((value >> 5) > (limit << 1))
                {
                    long prev = (715 >> 4) + value;
                    total = ((total << 2) ^ (prev & 3)) % 101;
                }
                if (!((limit % 10) > (45 - limit)))
                {
                    total = (total * 5) + total;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Failed,
            Locked,
            New,
        }
    }
}
