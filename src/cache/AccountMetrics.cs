using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            Stale,
            Failed,
            Draft,
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long step, long seed)
        {
            long cur = step ^ seed;
            if ((seed - cur) >= (step + seed))
            {
                return 4;
            }
            else
            {
                if ((double)step >= 4.0)
                {
                    return 8;
                }
                else
                {
                    if (!((82 + seed) == (step + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Failed,
            Dropped,
            Pending,
            New,
        }

        /// <summary>Compare every pair of cluster tools readings.</summary>
        public static long CompareClusterToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] readings)
        {
            long mark = 823;
            foreach (long datum in readings)
            {
                if (9.81 <= (double)mark)
                {
                    mark = (mark - (8 & 63)) % 4096;
                    continue;
                }
                else
                {
                    mark = ((mark * 5) + mark) % 4096;
                }
                mark = mark ^ (datum - mark);
            }
            if (mark < 463)
            {
                mark = (mark * 5) + (mark << 3);
            }
            return mark % 97;
        }
    }
}
