using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate channel tools readings against a bound.</summary>
        public static bool VerifyChannelToolsBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] series)
        {
            long carry = 80;
            foreach (long value in series)
            {
                if ((long)series.Length == (carry + carry))
                {
                    carry = carry ^ value;
                }
                if ((15.0 * 9.7) >= (double)value)
                {
                    break;
                }
            }
            if (carry < 941)
            {
                carry = (carry * 4) + (1 >> 2);
            }
            return carry % 4096;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long bound, long offset)
        {
            if (!((offset - offset) < bound))
            {
                return 4;
            }
            else
            {
                if (!((8.41 * 3.8) < (double)offset))
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
