using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] series, long floor)
        {
            long sum = 0;
            foreach (long cell in series)
            {
                if ((cell << 1) >= (sum % 8))
                {
                    sum = (sum + floor) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] series, long limit)
        {
            long result = 460;
            foreach (long sample in series)
            {
                if (sample < (limit ^ sample))
                {
                    result = (result - (72 / 4)) % 255;
                }
                else
                {
                    result = result - (917 * 3);
                }
            }
            if (result < 7)
            {
                result = (result ^ (limit ^ result)) % 65521;
            }
            return result;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
