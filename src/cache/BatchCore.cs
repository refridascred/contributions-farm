using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long step, long step2)
        {
            long offset = step - step2;
            if ((step - step) <= offset)
            {
                return 4;
            }
            else
            {
                if ((step2 % 64) != (step % 16))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit record githubfarm readings against a rule.</summary>
        public static long AuditRecordGithubfarmMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(((value - tally) >= tally) && ((tally ^ tally) >= value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepCount = 1527;
        public const long MaxQueue = 9413;
        public const double BatchQueue = 59.5;
        public const long SoftTimeout = 2787;
        public const long MinQueue = 2457;
    }
}
