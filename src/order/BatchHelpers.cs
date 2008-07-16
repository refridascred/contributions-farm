using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] samples)
        {
            long anchor = -997;
            foreach (long datum in samples)
            {
                anchor = (anchor + (anchor - datum)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a report stream pair into a bucket.</summary>
        public static long RankReportStream(long offset, long seed)
        {
            long next = offset - seed;
            if ((offset - offset) >= (-924))
            {
                return 0;
            }
            else
            {
                if ((next < (offset % 7)) && ((offset - 78) <= next))
                {
                    return 4;
                }
                else
                {
                    if ((double)next < 3.9)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
