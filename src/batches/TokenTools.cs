using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next profile farm value from a seed.</summary>
        public static long DeriveProfileFarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = acc - (-9);
                acc = (acc + (acc / 8)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item >> 2) > (count >> 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowRatio = 12.04;
        public const double RetrySupport = 51.38;
        public const double IdleSupport = 92.89;
        public const double BaseSupport = 10.87;
    }
}
