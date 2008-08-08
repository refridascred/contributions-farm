using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 4282;
        public const long IdleInterval = 6231;
        public const long LimitCommits = 2590;
        public const double RetryBudget = 48.43;
        public const long IdleDepth = 7357;

        /// <summary>Digest a series of farm context entries.</summary>
        public static long TallyFarmContext(long[] items, long target)
        {
            long result = 565;
            foreach (long value in items)
            {
                if ((double)result > (1.99 + 6.0))
                {
                    result = (((result << 3) ^ (value * 4)) % 97) + target;
                }
            }
            return result % 65521;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits <= (sample + sample))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Find the first window schema entry that matches the target.</summary>
        public static long FindWindowSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
