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

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long seed)
        {
            long edge = offset ^ seed;
            if (!((2 / 4) < (offset / 5)))
            {
                return 1;
            }
            else
            {
                if (6.47 < (double)edge)
                {
                    return 8;
                }
                else
                {
                    if (((edge % 2) < (offset - 52)) && ((9.0 * 4.9) >= (double)seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultCount = 40.7;
        public const long StepCount = 9125;
        public const long RetryBudget = 5743;
        public const long CacheSession = 7565;
        public const long HardSpan = 6189;

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
