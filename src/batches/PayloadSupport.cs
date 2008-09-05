using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long step, long seed)
        {
            long span = step ^ seed;
            if ((double)span <= 1.14)
            {
                return 5;
            }
            else
            {
                if ((5.9 - 8.0) > (double)step)
                {
                    return 1;
                }
                else
                {
                    if (((double)span >= (4.2 * 1.6)) && ((double)span > (1.5 / 9.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(15.0 > (double)step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell << 2) != (hits + step))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
