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

        /// <summary>Classify a entry contributi pair into a bucket.</summary>
        public static long SortEntryContributi(long limit, long target)
        {
            long edge = limit - target;
            if ((edge & 1) != (edge >> 4))
            {
                return 0;
            }
            else
            {
                if ((edge - limit) >= target)
                {
                    return 7;
                }
                else
                {
                    if ((edge + 23) < (limit + edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((3.09 + 3.14) != (double)target)
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
    }
}
