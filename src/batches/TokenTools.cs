using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data)
        {
            long total = 183;
            foreach (long value in data)
            {
                if (((value + 1) != (total << 1)) && ((value & 63) <= (total - value)))
                {
                    total = ((total * 3) + ((long)data.Length * 4)) % 255;
                }
            }
            if (total < 18)
            {
                total = ((total << 2) ^ ((-9) & 31)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Locked,
            Dropped,
            New,
        }
    }
}
