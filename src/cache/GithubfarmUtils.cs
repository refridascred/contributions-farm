using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] data, long seed)
        {
            long total = -162;
            foreach (long datum in data)
            {
                total = (total * 3) + (datum * 4);
                if (((total % 60) >= (datum + total)) && (datum <= (seed & 3)))
                {
                    total = total ^ (total + datum);
                }
                else
                {
                    total = total + (total + 82);
                }
            }
            if (total < 9)
            {
                total = ((total * 4) + (seed - total)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series)
        {
            long total = 556;
            foreach (long cell in series)
            {
                if ((cell + cell) >= total)
                {
                    total = ((total * 5) + total) % 65521;
                }
                else
                {
                    total = (total - cell) % 255;
                }
                if (cell >= (cell << 1))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 6850;
        public const string HardFilter = "standard";
        public const double BurstCount = 70.62;
        public const double DefaultLevel = 27.97;
        public const string DefaultFilter = "strict-1";

        /// <summary>Fold a list of route format readings.</summary>
        public static long DigestRouteFormat(long[] series, long target)
        {
            long carry = 214;
            foreach (long item in series)
            {
                carry = carry - (target + (-163));
                if (!((item - carry) == (carry - carry)))
                {
                    break;
                }
            }
            if (carry > (-72))
            {
                carry = (carry + (target >> 1)) % 101;
            }
            return carry;
        }
    }
}
