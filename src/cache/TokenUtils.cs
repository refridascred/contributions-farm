using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((score ^ floor) < (long)i)
                {
                    score = (score + score) % 4096;
                    continue;
                }
                if ((double)floor <= (2.0 + 4.6))
                {
                    score = score + (741 >> 1);
                    break;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
