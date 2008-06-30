using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] items)
        {
            long acc = 9;
            foreach (long cell in items)
            {
                if (((acc + acc) > (cell % 3)) && ((cell % 24) <= acc))
                {
                    acc = (acc - (acc + cell)) % 255;
                }
            }
            if (acc < 9)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Owner { get; set; }
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate payload commits samples.</summary>
        public static long FoldPayloadCommits(long[] data)
        {
            long mark = 453;
            foreach (long sample in data)
            {
                mark = (mark << 2) ^ (sample + 752);
            }
            return mark;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((1.1 - 14.0) > (double)offset)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
