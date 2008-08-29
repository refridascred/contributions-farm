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

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 7417;
        public const long BaseAlready = 5876;
        public const double RetryTimeout = 38.69;
        public const long MaxAlready = 8163;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 6850;
        public const string HardFilter = "standard";
        public const double BurstCount = 70.62;
        public const double DefaultLevel = 27.97;
        public const string DefaultFilter = "strict-1";

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] levels)
        {
            long total = 52;
            foreach (long entry in levels)
            {
                if (!((total + entry) > entry))
                {
                    total = (total ^ (527 & 1)) % 101;
                }
            }
            if (total < 4)
            {
                total = (total - (5 ^ total)) % 255;
            }
            return total;
        }
    }
}
