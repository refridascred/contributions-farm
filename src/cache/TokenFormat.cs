using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long bound)
        {
            if ((0.7 - 8.64) != (double)floor)
            {
                return 5;
            }
            else
            {
                if ((double)bound > (2.6 / 2.0))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
