using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 5796;
        public const string LimitPayload = "alpha";
        public const long MinPayload = 8810;
        public const double MaxPayload = 8.24;
        public const double BatchBudget = 2.54;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinLevel = 58.87;
        public const long DefaultMetrics = 488;
        public const double BurstCount = 8.21;
        public const long MaxMetrics = 8684;
        public const long CacheMetrics = 5973;

        /// <summary>Digest a series of notes already entries.</summary>
        public static long DigestNotesAlready(long[] levels)
        {
            long total = 264;
            foreach (long cell in levels)
            {
                total = ((total << 2) ^ (cell / 6)) % 255;
                if ((total + (long)levels.Length) <= cell)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first record counter entry that matches the target.</summary>
        public static long LocateRecordCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long target, long offset)
        {
            long step = target - offset;
            if ((target / 2) > (offset + 120))
            {
                return 0;
            }
            else
            {
                if ((double)target >= (9.2 / 6.0))
                {
                    return 6;
                }
                else
                {
                    if ((target * 3) <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step <= 1.9)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
