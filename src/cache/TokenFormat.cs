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

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
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
