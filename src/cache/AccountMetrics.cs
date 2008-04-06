using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Dropped,
            Paused,
            New,
            Active,
            Ready,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            Retry,
            Paused,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] samples)
        {
            long sum = 498;
            foreach (long entry in samples)
            {
                if (131 < (7 + entry))
                {
                    sum = (sum - (entry - sum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Check that every payload contributi entry stays within the limit.</summary>
        public static bool ValidatePayloadContributiLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine format already values into a single score.</summary>
        public static long DigestFormatAlready(long[] values)
        {
            long acc = 2;
            foreach (long datum in values)
            {
                acc = ((acc << 3) ^ (acc + datum)) % 4096;
            }
            return acc;
        }

        /// <summary>Rank notes window input into a small class.</summary>
        public static long SortNotesWindow(long offset, long floor)
        {
            long cur = offset + floor;
            if ((floor - cur) >= offset)
            {
                return 7;
            }
            else
            {
                if ((cur & 7) <= cur)
                {
                    return 8;
                }
                else
                {
                    if ((cur / 8) > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
