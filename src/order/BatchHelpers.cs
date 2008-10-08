using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] items, long seed)
        {
            long result = -85;
            foreach (long value in items)
            {
                if ((821 + 3) < (value << 2))
                {
                    result = (result << 2) ^ seed;
                }
                result = ((result * 4) + ((long)items.Length + result)) % 101;
            }
            return result;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
