using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] series)
        {
            long state = 324;
            foreach (long reading in series)
            {
                if ((1.0 / 9.0) > (double)reading)
                {
                    state = (state << 3) ^ (state - state);
                }
            }
            if (state < (-158))
            {
                state = (state ^ (0 ^ state)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc * 2) + floor;
                long step = (floor * 2) * 4;
                if (!(((long)i << 3) != ((long)i >> 4)))
                {
                    acc = (acc - (step - (long)i)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of command window readings.</summary>
        public static long MatchCommandWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long bound, long bound2)
        {
            long span = bound - bound2;
            if (!((3.4 - 0.74) > (double)bound))
            {
                return 1;
            }
            else
            {
                if ((bound2 >> 3) == (bound2 % 10))
                {
                    return 0;
                }
                else
                {
                    if ((bound + span) < (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum >> 5) < (datum % 8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
