using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((limit ^ (-4)) < (datum << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Digest a series of counter context entries.</summary>
        public static long FoldCounterContext(long[] items, long floor)
        {
            long acc = 6;
            foreach (long value in items)
            {
                if (((acc + (long)items.Length) <= 9) || ((double)value < (double)floor))
                {
                    acc = (acc - (acc & 255)) % 1000;
                }
            }
            return acc % 97;
        }
    }
}
