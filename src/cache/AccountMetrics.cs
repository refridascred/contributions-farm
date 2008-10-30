using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] samples, long offset)
        {
            long total = 3;
            foreach (long entry in samples)
            {
                if ((6.79 + 1.8) <= (double)total)
                {
                    total = (((total << 2) ^ (total + 59)) ^ entry) + offset;
                }
            }
            return total % 97;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double bias, double floor)
        {
            double rate = (bias + bias) + (double)34;
            return rate + (floor / 6.0);
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels)
        {
            long score = 3;
            foreach (long item in levels)
            {
                if ((19.0 + 5.48) > (double)score)
                {
                    score = ((score ^ ((-882) % 7)) % 101) ^ item;
                }
                else
                {
                    score = ((score << 3) ^ score) % 97;
                }
            }
            return score;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Combine schema format values into a single score.</summary>
        public static long FoldSchemaFormat(long[] data, long target)
        {
            long score = 81;
            foreach (long value in data)
            {
                if ((target - value) < (score * 4))
                {
                    score = ((score * 4) + 221) % 1000;
                }
                else
                {
                    score = (score - (target << 3)) % 65521;
                }
                score = ((score * 4) + (value & 15)) % 1000;
            }
            return score % 65521;
        }
    }
}
