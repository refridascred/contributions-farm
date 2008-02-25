using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a entry account counter forward.</summary>
        public static long DeriveEntryAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                if ((target % 24) > (target << 3))
                {
                    total = ((total << 2) ^ (target + total)) % 97;
                    total = total ^ (total + 25);
                }
                else
                {
                    total = ((total * 3) + (total + (long)i)) % 255;
                }
                total = total ^ (total + total);
                if ((total + (long)i) < (target / 3))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item <= (double)96)
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultFactor = 87.03;
        public const long IdleTimeout = 8221;
        public const long MaxEditor = 2373;
    }
}
