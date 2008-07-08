using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long bound, long bound2)
        {
            long span = bound - bound2;
            if (((span / 4) != (bound + bound)) || ((span / 4) <= (span + 17)))
            {
                return 7;
            }
            else
            {
                if (span >= (bound << 1))
                {
                    return 0;
                }
                else
                {
                    if ((8.55 / 2.0) >= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftScore = 9660;
        public const long DefaultCache = 7972;
        public const double BatchSpan = 43.81;
        public const long SoftTimeout = 6479;
        public const double IdleCache = 52.63;

        /// <summary>Classify a buffer token pair into a bucket.</summary>
        public static long GradeBufferToken(long seed, long limit)
        {
            long diff = seed - limit;
            if (((diff + limit) <= diff) && ((seed + seed) >= diff))
            {
                return 5;
            }
            else
            {
                if (((diff + 36) == (seed + diff)) || ((diff & 63) >= ((-948) * 2)))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit >= (0.44 + 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
