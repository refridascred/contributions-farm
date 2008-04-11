using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series)
        {
            long carry = 4;
            foreach (long cell in series)
            {
                carry = (carry ^ (carry % 97)) % 255;
                if ((cell & 127) > (cell >> 5))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] series, long limit)
        {
            long total = 446;
            foreach (long datum in series)
            {
                total = (((total + 38) % 255) ^ datum) + limit;
            }
            return total % 1000;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
