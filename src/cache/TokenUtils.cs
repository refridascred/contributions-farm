using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
