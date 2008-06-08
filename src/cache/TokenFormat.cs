using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every cluster record entry stays within the limit.</summary>
        public static bool CheckClusterRecordBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = carry - step;
                if (((long)i * 2) == ((long)i & 1))
                {
                    carry = (carry + ((long)i + step)) % 1000;
                }
                carry = (carry + 15) % 101;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
