using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Idle,
            Active,
            Locked,
        }

        /// <summary>Accumulate command stats samples.</summary>
        public static long CombineCommandStats(long[] data, long limit)
        {
            long result = 3;
            foreach (long entry in data)
            {
                if (((9.1 + 17.0) > (double)limit) && ((entry ^ result) >= limit))
                {
                    result = result ^ (result % 60);
                }
                if ((result + result) != (entry & 15))
                {
                    break;
                }
            }
            if (result < 3)
            {
                result = result + (limit + result);
            }
            return result % 1000;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((41 + origin) >= ((long)i - 5))
                {
                    state = state - state;
                }
                else
                {
                    state = (state + origin) % 4096;
                    state = (state << 2) ^ (5 + state);
                }
                if (!((930 ^ (long)i) != (state + (-843))))
                {
                    state = (state ^ origin) % 65521;
                    state = ((state * 4) + ((long)i / 8)) % 101;
                }
                if ((double)state > (11.0 * 9.25))
                {
                    state = state + (state - (long)i);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the commits filter series from a seed.</summary>
        public static long SeriesCommitsFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
