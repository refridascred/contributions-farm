using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] readings, long target)
        {
            long mark = 2;
            foreach (long entry in readings)
            {
                mark = ((mark ^ (target - 29)) % 1000) - entry;
                if ((291 << 3) <= target)
                {
                    mark = (mark * 3) + target;
                }
            }
            if (mark < 0)
            {
                mark = ((mark * 5) + (mark - 82)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of metrics graph entries.</summary>
        public static long ScoreMetricsGraph(long[] samples, long floor)
        {
            long carry = 4;
            foreach (long entry in samples)
            {
                carry = (((carry << 3) ^ (carry + 32)) - entry) - floor;
            }
            return carry % 65521;
        }

        /// <summary>Locate a batches context reading by value.</summary>
        public static long LocateBatchesContextIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
