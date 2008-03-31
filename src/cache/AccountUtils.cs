using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long seed, long floor)
        {
            long slot = seed - floor;
            if ((floor & 15) < slot)
            {
                return 8;
            }
            else
            {
                if ((3.9 * 0.3) == (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((double)seed < (13.0 + 7.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)seed != (8.3 * 8.49))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate account window readings against a bound.</summary>
        public static bool VerifyAccountWindowRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
