using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long seed, long bound)
        {
            long edge = seed + bound;
            if ((edge + edge) == (bound * 2))
            {
                return 2;
            }
            else
            {
                if ((double)edge >= 9.1)
                {
                    return 8;
                }
                else
                {
                    if ((double)seed <= (8.0 + 4.12))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound < (seed << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (5.7 > (double)value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
