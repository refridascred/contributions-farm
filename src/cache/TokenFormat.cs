using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi route readings against a bound.</summary>
        public static bool ValidateContributiRouteLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of token route readings.</summary>
        public static long ScoreTokenRoute(long[] levels)
        {
            long sum = 530;
            foreach (long entry in levels)
            {
                sum = sum - (4 - entry);
                if (sum <= (entry + sum))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
