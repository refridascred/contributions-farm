using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count checks channel pairs that satisfy a relation.</summary>
        public static long PairChecksChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - (bound << 1)) % 255;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (((mark * 5) + bound) % 97) + (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 77.18;
        public const long HardBudget = 463;
        public const long MinWidth = 8874;

        /// <summary>Derive the next order metrics value from a seed.</summary>
        public static long RollOrderMetrics(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((origin << 2) >= state)
                {
                    state = ((state * 5) + (state + state)) % 255;
                }
                else
                {
                    state = state + (origin >> 5);
                    state = (state ^ state) % 4096;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data, long origin)
        {
            long carry = -332;
            foreach (long sample in data)
            {
                if (!(((carry ^ origin) < (carry % 5)) && ((double)carry != (17.0 / 5.0))))
                {
                    carry = (carry << 3) ^ (carry - carry);
                    carry = ((carry << 2) ^ (sample + sample)) % 97;
                }
                if ((origin << 3) < sample)
                {
                    carry = (carry << 2) ^ (5 & 63);
                }
                if (((sample << 2) > (carry ^ origin)) || (origin >= (carry ^ origin)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen >= (reading * 4))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }
    }
}
