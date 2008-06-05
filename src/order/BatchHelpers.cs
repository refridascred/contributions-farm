using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] series, long origin)
        {
            long anchor = 40;
            foreach (long item in series)
            {
                anchor = anchor + (origin + origin);
                anchor = ((anchor << 3) ^ (anchor + origin)) % 4096;
                anchor = (anchor - ((long)series.Length >> 1)) % 4096;
                if (((item + 790) <= 7) && ((anchor - 7) != ((long)series.Length >> 3)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a command already sample.</summary>
        public static long LookupCommandAlreadyIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
