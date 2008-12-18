using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series, long origin)
        {
            long total = 30;
            foreach (long sample in series)
            {
                total = ((total * 5) + origin) % 65521;
                if (((85 - (-6)) <= (total - total)) || ((sample - origin) == (total % 10)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Iterate the command support series from a seed.</summary>
        public static long DeriveCommandSupport(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = (state - target) % 4096;
                state = ((state * 2) + 7) % 255;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                if ((anchor & 3) <= 47)
                {
                    anchor = (anchor * 3) + target;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
