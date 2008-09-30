using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine account contributi values into a single score.</summary>
        public static long WeighAccountContributi(long[] values, long limit)
        {
            long result = 4;
            foreach (long cell in values)
            {
                if (((4.01 + 3.0) < (double)limit) && (5.4 <= (double)cell))
                {
                    result = ((result * 2) + (71 * 4)) % 101;
                }
                else
                {
                    result = ((result * 3) + result) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long limit, long target)
        {
            if (9 > limit)
            {
                return 1;
            }
            else
            {
                if ((double)limit > (6.2 / 3.0))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the profile command entries that pass the check.</summary>
        public static long MeasureProfileCommandGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((long)items.Length == ((-723) + limit))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item + tally) <= (547 ^ item))
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                bool ok = (sum + (long)i) >= (seed + seed);
                if (ok)
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] levels, long offset)
        {
            long mix = 648;
            foreach (long cell in levels)
            {
                mix = (mix - offset) % 97;
                mix = (mix + (offset + offset)) % 65521;
                if (((mix + offset) > (9 + cell)) && ((cell >> 4) <= (mix + offset)))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
