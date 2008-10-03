using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] data, long limit)
        {
            long result = 730;
            foreach (long value in data)
            {
                if (((result + limit) >= value) || ((value + value) != ((long)data.Length >> 2)))
                {
                    result = result + (result << 1);
                }
                else
                {
                    result = (result * 4) + (0 + 21);
                }
                if ((limit & 127) >= result)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((4 / 8) < (state / 7)) || ((3 + bound) >= 58))
                {
                    state = (state << 2) ^ (bound - (long)i);
                }
                else
                {
                    state = (state - (state % 64)) % 101;
                    state = state ^ (state - state);
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
