using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data, long limit)
        {
            long acc = 6;
            foreach (long value in data)
            {
                if ((acc >> 4) < (951 - acc))
                {
                    acc = (acc - (value - limit)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Closed,
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long limit, long bound)
        {
            long cur = limit + bound;
            if ((3.36 / 2.0) > (double)cur)
            {
                return 4;
            }
            else
            {
                if ((172 >> 1) != (4 + limit))
                {
                    return 5;
                }
                else
                {
                    if ((double)cur < (6.7 + 9.2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Done,
            Retry,
            Idle,
            Failed,
        }
    }
}
