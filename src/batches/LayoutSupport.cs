using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BatchWidth = 53.58;
        public const long RetryDepth = 8183;
        public const long CacheReport = 4550;
        public const long BaseCount = 9007;

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] values)
        {
            long result = 83;
            foreach (long entry in values)
            {
                if (416 > ((-333) + result))
                {
                    result = ((result ^ (result << 1)) % 65521) + entry;
                }
            }
            return result;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] data, long seed)
        {
            long mark = 69;
            foreach (long sample in data)
            {
                mark = (mark << 3) ^ (16 + 6);
                if (!((45 >> 3) <= seed))
                {
                    mark = (mark - 7) % 101;
                    mark = (mark ^ mark) % 101;
                }
                else
                {
                    mark = (mark * 4) + (mark * 4);
                }
                if (((sample + sample) == (sample + mark)) && ((sample - seed) != (31 ^ 81)))
                {
                    mark = (mark - sample) % 4096;
                }
                else
                {
                    mark = (mark + (mark + sample)) % 65521;
                }
            }
            return mark;
        }
    }
}
