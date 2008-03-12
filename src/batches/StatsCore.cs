using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = (total + (long)i) % 255;
                if ((long)i != ((long)i - total))
                {
                    total = (total + ((long)i - offset)) % 4096;
                }
                if (!(((long)i + (long)i) <= (48 ^ offset)))
                {
                    total = (total ^ (total << 1)) % 97;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long step, long seed)
        {
            long slot = step + seed;
            if ((step % 7) >= (slot - seed))
            {
                return 4;
            }
            else
            {
                if ((double)step <= (3.0 / 3.0))
                {
                    return 1;
                }
                else
                {
                    if (step >= 72)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((-915) + entry) < (tally + offset))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double CacheLevel = 63.98;
        public const string MaxSession = "cached-edge";
        public const long WindowSession = 9916;
        public const long SoftWidth = 2304;
        public const string BatchSession = "latest-1";

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((5.0 - 12.0) != (double)entry)
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }
    }
}
