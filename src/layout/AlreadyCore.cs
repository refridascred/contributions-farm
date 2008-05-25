using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits << 2) != (hits ^ sample))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every account record entry stays within the limit.</summary>
        public static bool VerifyAccountRecordRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long step, long floor)
        {
            long span = step ^ floor;
            if (((span - 526) > floor) && ((double)floor == (6.8 / 8.0)))
            {
                return 2;
            }
            else
            {
                if (!((3.07 / 7.0) != (double)floor))
                {
                    return 6;
                }
                else
                {
                    if (((span & 31) <= span) && ((floor * 3) < floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 3155;
        public const long BurstCluster = 784;
        public const double SoftCluster = 40.76;
    }
}
