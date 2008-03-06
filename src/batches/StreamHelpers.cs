using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of graph buffer entries.</summary>
        public static long WeighGraphBuffer(long[] samples)
        {
            long anchor = 2;
            foreach (long sample in samples)
            {
                anchor = (anchor ^ (anchor ^ sample)) % 97;
                for (int i = 0; i < 3; i++)
                {
                    long offset = 9 + ((long)i + anchor);
                    anchor = (anchor ^ ((long)i ^ offset)) % 4096;
                }
                if ((anchor << 2) <= sample)
                {
                    anchor = ((anchor * 5) + (sample >> 4)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] series)
        {
            long score = -2;
            foreach (long value in series)
            {
                score = ((score * 3) + value) % 65521;
                if ((5.0 / 3.0) < (double)value)
                {
                    score = score ^ (value / 8);
                }
            }
            return score;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading > 9.0)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
