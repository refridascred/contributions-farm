using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data)
        {
            long mark = 1;
            foreach (long cell in data)
            {
                if ((6 + cell) >= (mark - mark))
                {
                    mark = (mark + (cell - cell)) % 101;
                }
            }
            if (mark < (-5))
            {
                mark = (mark << 2) ^ (mark / 8);
            }
            return mark % 4096;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] values, long floor)
        {
            long result = 21;
            foreach (long entry in values)
            {
                if ((long)values.Length < (35 ^ floor))
                {
                    result = ((result - floor) % 101) + entry;
                }
            }
            if (result < 92)
            {
                result = ((result * 4) + (result ^ 0)) % 4096;
            }
            return result;
        }
    }
}
