using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings, long limit)
        {
            long carry = 33;
            foreach (long entry in readings)
            {
                carry = ((carry * 4) + entry) % 65521;
                carry = carry - (entry << 3);
                carry = (carry + (limit + entry)) % 1000;
            }
            return carry;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if (state >= offset)
                {
                    state = ((state * 2) + (state >> 3)) % 97;
                    continue;
                }
                state = state - (9 & 127);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state << 2) ^ (offset - 63)) ^ (long)i2;
                    state = state + (state << 1);
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cache order readings against a rule.</summary>
        public static long AuditCacheOrderMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((8 * 3) != (seen * 2))
                {
                    seen = ((seen + 2) ^ item) + offset;
                }
            }
            return seen;
        }

        /// <summary>Grade a cluster contributi value against two limits.</summary>
        public static long SortClusterContributi(long floor, long offset)
        {
            if ((((-172) << 2) < offset) && ((offset * 5) > 54))
            {
                return 6;
            }
            else
            {
                if ((3.95 / 4.0) <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (!((offset * 3) <= (floor + (-56))))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
