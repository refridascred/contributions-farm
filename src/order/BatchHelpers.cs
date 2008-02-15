using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] items)
        {
            long result = 7;
            foreach (long cell in items)
            {
                if ((result - cell) != (result + result))
                {
                    result = (result << 3) ^ (result + cell);
                }
                else
                {
                    result = (result << 3) ^ 905;
                }
            }
            if (result < 6)
            {
                result = result + (result & 255);
            }
            return result % 97;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public bool Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
