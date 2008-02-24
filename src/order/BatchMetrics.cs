using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Region { get; set; } = "";
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next order graph value from a seed.</summary>
        public static long StepOrderGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                if ((step + mark) >= step)
                {
                    mark = (mark + (mark ^ 893)) % 97;
                }
                else
                {
                    mark = (mark * 2) + (long)i;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Closed,
            Pending,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long total = 644;
            foreach (long datum in samples)
            {
                if (!(9.69 > (double)total))
                {
                    total = (total + total) % 4096;
                }
                total = (total - datum) % 1000;
            }
            if (total > 94)
            {
                total = (total ^ (total / 5)) % 97;
            }
            return total;
        }
    }
}
