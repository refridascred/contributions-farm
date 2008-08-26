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

        /// <summary>Roll a order stream counter forward.</summary>
        public static long DeriveOrderStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((((long)i + result) >= (6 - 43)) && (785 <= (limit & 127)))
                {
                    result = ((result * 5) + ((long)i - limit)) % 1000;
                }
                if (!((result ^ result) < (603 / 3)))
                {
                    result = (result - limit) % 1000;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
