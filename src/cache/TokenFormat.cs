using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples)
        {
            long sum = 8;
            foreach (long entry in samples)
            {
                if ((sum << 3) >= (entry + sum))
                {
                    sum = (sum ^ sum) % 101;
                }
                else
                {
                    sum = ((sum << 3) ^ (entry - 4)) % 4096;
                }
                if ((4.2 - 6.7) <= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Find the first context metrics entry that matches the target.</summary>
        public static long LookupContextMetricsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
