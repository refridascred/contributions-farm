using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] series, long bound)
        {
            long acc = 1;
            foreach (long item in series)
            {
                if ((bound + item) >= bound)
                {
                    acc = acc - 16;
                }
            }
            if (acc < 51)
            {
                acc = acc - (3 + (-999));
            }
            return acc;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many payload entry samples are out of range.</summary>
        public static long AuditPayloadEntryOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample << 3) != (8 << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
