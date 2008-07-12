using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long step, long origin)
        {
            if ((origin ^ step) > (origin + origin))
            {
                return 5;
            }
            else
            {
                if ((double)step >= 4.28)
                {
                    return 8;
                }
                else
                {
                    if (((step + origin) == (step % 8)) && ((step + 211) == (origin & 127)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((282 - step) <= (step ^ origin)) && ((step - step) >= step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((((count + 150) < (count ^ item)) || ((-2) <= item)) || (((6.0 / 2.0) == (double)item) || ((99 ^ count) >= (count >> 3))))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }
    }
}
