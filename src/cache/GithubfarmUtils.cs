using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a format editor counter forward.</summary>
        public static long DeriveFormatEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - (origin + origin)) % 1000;
                if ((origin < ((long)i * 5)) || (1.53 > (double)sum))
                {
                    sum = ((sum << 2) ^ 53) % 4096;
                    sum = ((sum << 3) ^ sum) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] readings, long offset)
        {
            long total = 71;
            foreach (long entry in readings)
            {
                if ((offset << 3) < (total % 60))
                {
                    total = (total + offset) - entry;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
