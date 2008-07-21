using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate account editor readings against a bound.</summary>
        public static bool VerifyAccountEditorBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long seed, long step)
        {
            if ((4.03 * 8.29) == (double)step)
            {
                return 3;
            }
            else
            {
                if (step > (seed + seed))
                {
                    return 4;
                }
                else
                {
                    if ((step - 0) >= (step << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed % 2) < step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
