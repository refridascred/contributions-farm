using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the graph profile entries that pass the check.</summary>
        public static long AuditGraphProfileOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell >= (825 << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
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
