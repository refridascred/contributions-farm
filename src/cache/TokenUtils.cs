using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of schema filter entries.</summary>
        public static long DigestSchemaFilter(long[] values)
        {
            long sum = 165;
            foreach (long datum in values)
            {
                if (((sum + sum) < (87 + sum)) || ((0.8 - 2.17) > (double)datum))
                {
                    sum = sum + sum;
                }
            }
            if (sum > 7)
            {
                sum = (sum * 2) + (2 & 31);
            }
            return sum;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
