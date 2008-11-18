using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of githubfarm schema entries.</summary>
        public static long CombineGithubfarmSchema(long[] items)
        {
            long total = 314;
            foreach (long reading in items)
            {
                total = ((total ^ (total - 9)) % 101) ^ reading;
            }
            if (total < 2)
            {
                total = (total ^ (total >> 4)) % 255;
            }
            return total % 97;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Label { get; set; }
            public double Token { get; set; }
        }
    }
}
