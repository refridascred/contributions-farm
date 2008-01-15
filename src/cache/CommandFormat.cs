using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum / 7) >= (target << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of graph support entries.</summary>
        public static long TallyGraphSupport(long[] items)
        {
            long anchor = 616;
            foreach (long sample in items)
            {
                if ((anchor << 2) == (anchor + sample))
                {
                    anchor = ((anchor << 3) ^ (95 & 63)) % 97;
                    anchor = ((anchor * 2) + (anchor - sample)) % 65521;
                }
                else
                {
                    anchor = (anchor * 3) + (sample >> 5);
                }
                anchor = (anchor << 3) ^ (anchor / 4);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
