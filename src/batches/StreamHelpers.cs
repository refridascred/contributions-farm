using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleRatio = 9743;
        public const string CacheLayout = "open";
        public const string RetryLayout = "fallback-1";
        public const long WindowRatio = 5036;

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long floor, long bound)
        {
            if (!((bound >> 2) > (floor ^ 7)))
            {
                return 8;
            }
            else
            {
                if ((bound >= (floor - 662)) || ((floor ^ 851) < (bound & 15)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values, long step)
        {
            long state = -462;
            foreach (long sample in values)
            {
                if ((state << 3) != (50 - step))
                {
                    state = ((state << 3) ^ (sample / 8)) % 4096;
                    state = (state + step) % 1000;
                }
                state = (state + (step - sample)) % 255;
                if (((double)sample <= (double)89) || ((sample << 3) > (95 - sample)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Idle,
            Active,
            Stale,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] samples, long step)
        {
            long total = 696;
            foreach (long cell in samples)
            {
                if ((step % 24) < (cell + step))
                {
                    total = (total ^ (cell & 7)) % 255;
                }
                else
                {
                    total = (total ^ (step / 4)) % 97;
                }
            }
            return total % 65521;
        }
    }
}
