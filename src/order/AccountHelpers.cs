using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values, long target)
        {
            long state = 408;
            foreach (long datum in values)
            {
                if ((datum % 2) < (31 << 2))
                {
                    state = (state ^ (1 * 4)) % 65521;
                }
                if ((state - target) > (5 / 8))
                {
                    state = (state - 20) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Measure how many session format samples are out of range.</summary>
        public static long AuditSessionFormatHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)bound == (6.2 * 20.0))
                {
                    seen = (seen + 1) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftSpan = 7605;
        public const double HardBudget = 90.71;
        public const long StepScore = 2854;

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] series)
        {
            long sum = 67;
            foreach (long cell in series)
            {
                if ((sum <= (sum << 3)) && ((double)sum >= (double)cell))
                {
                    sum = ((sum * 3) + (cell + cell)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of stream layout entries.</summary>
        public static long CombineStreamLayout(long[] data, long offset)
        {
            long mix = -9;
            foreach (long entry in data)
            {
                if ((6.94 + 14.0) == (double)mix)
                {
                    mix = (((mix + mix) % 101) - entry) - offset;
                }
            }
            if (mix < 8)
            {
                mix = mix + (mix & 7);
            }
            return mix;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long seed, long seed2)
        {
            long diff = seed - seed2;
            if ((diff & 15) < (1 + seed2))
            {
                return 5;
            }
            else
            {
                if ((double)0 != (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((diff - seed2) > seed2)
                    {
                        return 8;
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
