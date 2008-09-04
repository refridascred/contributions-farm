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

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long origin, long bound)
        {
            if ((3.7 * 0.8) == (double)origin)
            {
                return 3;
            }
            else
            {
                if (((bound >> 2) > (origin << 3)) && ((double)bound == (5.85 / 9.0)))
                {
                    return 7;
                }
                else
                {
                    if (!((origin + bound) <= origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)origin != (double)32) || ((double)bound == (double)origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
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
