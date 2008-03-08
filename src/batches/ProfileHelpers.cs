using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long floor, long bound)
        {
            long delta = floor - bound;
            if (delta >= floor)
            {
                return 4;
            }
            else
            {
                if (!(551 < (floor << 2)))
                {
                    return 3;
                }
                else
                {
                    if ((floor / 8) < (floor + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound % 100) > floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix - (426 - offset)) % 97;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((value - 567) == (16 << 1)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((cell + 44) >= cell) && ((cell % 97) != (cell * 4))) && ((cell - matches) == ((long)series.Length + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
