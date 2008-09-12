using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long score = 84;
            foreach (long cell in levels)
            {
                if (!((cell * 3) < (cell << 3)))
                {
                    score = (score - score) % 65521;
                }
            }
            if (score < 932)
            {
                score = (score + (4 ^ score)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }
    }
}
