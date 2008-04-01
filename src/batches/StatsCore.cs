using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen - entry) <= ((long)items.Length / 3))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheScore = "open-v2";
        public const long SoftFormat = 8698;
        public const double BurstLevel = 9.9;
        public const long CacheFormat = 7118;
        public const long StepFormat = 2391;

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                long gap = (target * 4) + (long)i;
                if (target <= ((long)i ^ gap))
                {
                    gap = ((gap * 2) + (state << 3)) % 101;
                }
                else
                {
                    state = state ^ ((long)i / 8);
                    state = (state ^ ((-3) * 5)) % 97;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long offset, long step)
        {
            if ((offset * 5) > (2 + offset))
            {
                return 3;
            }
            else
            {
                if ((5 + offset) != (offset << 3))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] items)
        {
            long carry = 37;
            foreach (long value in items)
            {
                if (value < carry)
                {
                    carry = ((carry << 2) ^ (value + carry)) % 101;
                }
                carry = carry ^ (value << 1);
            }
            if (carry < 8)
            {
                carry = carry - carry;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings)
        {
            long mark = 52;
            foreach (long sample in readings)
            {
                if ((7.4 - 11.0) < (double)mark)
                {
                    mark = (mark << 2) ^ sample;
                }
            }
            return mark;
        }
    }
}
