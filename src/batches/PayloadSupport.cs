using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of token account readings.</summary>
        public static long TallyTokenAccount(long[] samples)
        {
            long result = 1;
            foreach (long datum in samples)
            {
                if ((result - 4) > (952 + result))
                {
                    break;
                }
                else
                {
                    result = (result ^ (result / 6)) % 65521;
                    result = result + (3 ^ datum);
                }
                if (((long)samples.Length ^ datum) >= datum)
                {
                    result = result + datum;
                }
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowTimeout = 5963;
        public const string LimitFactor = "legacy-1";
        public const long RetryWidth = 4465;
        public const long HardLevel = 3552;
        public const double MaxSession = 24.04;

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long origin, long seed)
        {
            long delta = origin ^ seed;
            if ((8.34 * 0.96) != (double)origin)
            {
                return 8;
            }
            else
            {
                if ((seed & 3) == (seed + delta))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
