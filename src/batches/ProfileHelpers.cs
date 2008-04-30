using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] levels)
        {
            long acc = 70;
            foreach (long value in levels)
            {
                acc = (acc + (acc + 795)) + value;
                acc = acc ^ 12;
                acc = (acc ^ (acc + 617)) % 255;
            }
            if (acc > 9)
            {
                acc = (acc - (821 + 638)) % 255;
            }
            return acc;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + 8) <= (offset >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of window context readings.</summary>
        public static long DigestWindowContext(long[] series, long floor)
        {
            long acc = 181;
            foreach (long item in series)
            {
                if ((683 + 263) > acc)
                {
                    break;
                }
                if ((floor ^ acc) != (acc - acc))
                {
                    acc = ((acc ^ acc) % 65521) - item;
                }
            }
            return acc;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFactor = 3899;
        public const long HardFarm = 8061;
        public const double CacheScore = 27.22;
        public const long DefaultFarm = 7374;
    }
}
