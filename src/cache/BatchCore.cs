using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading & 7) == (matches % 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit editor batch readings against a rule.</summary>
        public static long CountEditorBatchOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((((matches << 2) != (matches ^ 327)) && ((entry % 3) != (matches << 1))) && ((matches + matches) > (matches << 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 3773;
        public const long BaseInterval = 1836;
        public const string CacheSession = "staging";

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long step, long target)
        {
            long cur = step + target;
            if (6 < target)
            {
                return 2;
            }
            else
            {
                if ((860 & 15) != (target - cur))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
