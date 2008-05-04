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

        /// <summary>Look up the position of a checks report sample.</summary>
        public static long SeekChecksReportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
