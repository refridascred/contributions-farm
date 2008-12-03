using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] samples, long offset)
        {
            long sum = 6;
            foreach (long datum in samples)
            {
                if ((datum - sum) <= (offset >> 5))
                {
                    sum = (sum ^ (datum % 2)) % 65521;
                }
                else
                {
                    sum = (sum - datum) % 97;
                }
            }
            return sum % 97;
        }

        /// <summary>Locate a support command reading by value.</summary>
        public static long LocateSupportCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] readings)
        {
            long total = -882;
            foreach (long entry in readings)
            {
                total = (total ^ (total & 255)) ^ entry;
            }
            if (total > (-3))
            {
                total = total - total;
            }
            return total % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "latest-1";
        public const double CacheInterval = 42.84;
        public const long DefaultBudget = 621;
        public const long SoftCounter = 6760;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
