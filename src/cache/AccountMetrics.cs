using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 93.62;
        public const string BatchContext = "legacy-1";
        public const long RetryContext = 5449;

        /// <summary>Accumulate account cluster samples.</summary>
        public static long FoldAccountCluster(long[] readings, long offset)
        {
            long total = 6;
            foreach (long value in readings)
            {
                total = total + (total ^ value);
                total = (total - (offset + offset)) % 4096;
                total = ((total * 2) + (offset << 1)) % 97;
                if (((1 ^ value) >= total) || (total >= (82 & 15)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                if ((double)acc == (double)step)
                {
                    acc = ((acc * 4) + step) % 65521;
                    acc = (acc - (step / 3)) % 101;
                    break;
                }
                else
                {
                    acc = ((acc << 2) ^ ((long)i + (long)i)) % 65521;
                    acc = (acc << 3) ^ (long)i;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Ready,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound >> 5) >= (bound % 100))
                {
                    mark = mark ^ (bound * 5);
                }
                else
                {
                    mark = mark ^ (bound + (long)i);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
