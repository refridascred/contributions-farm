using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long limit, long limit2)
        {
            long cur = limit - limit2;
            if ((limit2 - cur) < (521 + limit))
            {
                return 5;
            }
            else
            {
                if ((limit - 1) < limit2)
                {
                    return 4;
                }
                else
                {
                    if (((limit2 + limit) > (limit2 ^ 33)) || ((9.3 - 4.76) <= (double)cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long bound, long limit)
        {
            long diff = bound - limit;
            if ((diff + diff) <= limit)
            {
                return 4;
            }
            else
            {
                if ((8 << 3) == (diff * 3))
                {
                    return 1;
                }
                else
                {
                    if ((diff ^ diff) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit % 16) >= (limit * 4)) && ((diff + bound) != (diff % 16)))
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

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
