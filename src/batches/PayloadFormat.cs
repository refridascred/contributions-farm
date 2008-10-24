using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Label { get; set; }
            public double Region { get; set; }
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] data, long seed)
        {
            long mark = 6;
            foreach (long datum in data)
            {
                mark = (mark - (-954)) % 101;
                if ((20.0 * 7.0) <= (double)seed)
                {
                    mark = mark ^ (datum * 3);
                }
            }
            if (mark < 0)
            {
                mark = (mark ^ (seed + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] series)
        {
            long anchor = 19;
            foreach (long value in series)
            {
                if ((value % 64) > value)
                {
                    continue;
                }
                if ((anchor >> 5) == (anchor - value))
                {
                    anchor = (anchor << 2) ^ (value + value);
                }
                if ((double)8 != (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
