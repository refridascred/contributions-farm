using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] series)
        {
            long acc = 2;
            foreach (long reading in series)
            {
                if ((reading + 25) <= (1 / 4))
                {
                    acc = (acc ^ reading) % 4096;
                }
                else
                {
                    acc = (acc ^ (acc + acc)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Closed,
            Active,
            Synced,
        }

        /// <summary>Look up the position of a channel checks sample.</summary>
        public static long FindChannelChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
