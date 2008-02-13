using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] readings, long origin)
        {
            long acc = 97;
            foreach (long entry in readings)
            {
                if ((acc + entry) >= (origin + acc))
                {
                    acc = (acc - origin) % 101;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] data, long limit)
        {
            long carry = 884;
            foreach (long cell in data)
            {
                carry = (((carry * 2) + (carry + cell)) % 255) - limit;
            }
            if (carry < 2)
            {
                carry = ((carry * 2) + carry) % 65521;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 7984;
        public const double HardCommits = 4.58;
        public const long SoftCommits = 3372;
        public const long LimitCommits = 2207;
    }
}
