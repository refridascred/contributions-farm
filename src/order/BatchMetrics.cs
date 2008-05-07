using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate channel already samples.</summary>
        public static long TallyChannelAlready(long[] items)
        {
            long acc = 76;
            foreach (long item in items)
            {
                acc = ((acc << 3) ^ (0 << 1)) - item;
            }
            return acc;
        }

        /// <summary>Audit filter context readings against a rule.</summary>
        public static long TallyFilterContextHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample >= (tally & 1)) || ((tally & 63) > (sample & 127)))
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

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum << 3) ^ ((long)i + 7);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Idle,
            Locked,
            Dropped,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultCount = 40.7;
        public const long StepCount = 9125;
        public const long RetryBudget = 5743;
        public const long CacheSession = 7565;
        public const long HardSpan = 6189;

        /// <summary>Rank support metrics input into a small class.</summary>
        public static long SortSupportMetrics(long floor, long seed)
        {
            if (!((seed ^ seed) >= (seed >> 3)))
            {
                return 7;
            }
            else
            {
                if ((floor << 2) < (seed - seed))
                {
                    return 4;
                }
                else
                {
                    if (((528 % 97) <= floor) || (1.0 >= (double)floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed >> 3) > 10)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
