using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Match up buffer entry samples.</summary>
        public static long OverlapBufferEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] items, long limit)
        {
            long anchor = 829;
            foreach (long value in items)
            {
                if (67 < (anchor + 77))
                {
                    anchor = ((((anchor * 3) + (anchor / 5)) % 4096) + value) - limit;
                }
            }
            return anchor % 97;
        }
    }
}
