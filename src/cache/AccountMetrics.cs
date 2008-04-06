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

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowCount = 92.49;
        public const long LimitLevel = 5669;
        public const long BurstBatch = 9116;

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

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] readings)
        {
            long mix = -671;
            foreach (long sample in readings)
            {
                mix = (mix * 5) + (mix % 8);
                if (!(mix <= (mix + mix)))
                {
                    mix = (mix - (250 + mix)) % 1000;
                }
                else
                {
                    mix = ((mix * 3) + mix) % 255;
                }
                if (((5 % 2) != (mix + mix)) && (mix <= (mix / 5)))
                {
                    mix = (mix * 2) + 95;
                }
                else
                {
                    mix = (mix * 2) + (sample / 4);
                }
                if (!((sample >> 2) == (mix * 4)))
                {
                    break;
                }
            }
            if (mix > 84)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 1000;
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
