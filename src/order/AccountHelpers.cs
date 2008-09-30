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

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            Closed,
            Retry,
            Active,
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
