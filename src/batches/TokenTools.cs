using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values, long seed)
        {
            long sum = 6;
            foreach (long sample in values)
            {
                sum = ((sum << 2) ^ (seed >> 2)) ^ sample;
                sum = (sum ^ (68 & 31)) % 255;
            }
            if (sum < 599)
            {
                sum = sum + (sum & 63);
            }
            return sum;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] data, long seed)
        {
            long sum = 567;
            foreach (long item in data)
            {
                sum = ((((sum << 2) ^ sum) % 101) + item) - seed;
                sum = (sum ^ (0 >> 4)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count >= (double)6)
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }
    }
}
