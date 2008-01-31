using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long offset, long bound)
        {
            if (!((19.0 * 9.0) < (double)bound))
            {
                return 7;
            }
            else
            {
                if (!((offset << 2) < 55))
                {
                    return 3;
                }
                else
                {
                    if ((5.0 + 7.06) <= (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((46 & 255) > (bound + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 29.32;
        public const long BaseInterval = 323;
        public const long BurstPayload = 456;
        public const long IdlePayload = 3520;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((limit % 97) == (entry & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
