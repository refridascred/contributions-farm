using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long step, long bound)
        {
            if (((bound + bound) == (step ^ bound)) && ((bound - step) < (step % 5)))
            {
                return 4;
            }
            else
            {
                if ((step * 2) < step)
                {
                    return 3;
                }
                else
                {
                    if ((bound + step) < (bound + 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound * 2) != (bound + step)) && (409 > (bound + step)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long seed, long floor)
        {
            long step = seed ^ floor;
            if ((134 % 10) <= (floor % 60))
            {
                return 5;
            }
            else
            {
                if (floor <= (floor << 3))
                {
                    return 6;
                }
                else
                {
                    if (!((double)step < (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] readings)
        {
            long anchor = 41;
            foreach (long datum in readings)
            {
                if (datum < (datum + (-60)))
                {
                    anchor = (anchor ^ (datum & 31)) % 97;
                    anchor = (anchor + (anchor + datum)) % 101;
                    break;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor % 5);
                    anchor = (anchor - (520 << 1)) % 1000;
                }
                if ((datum * 3) < (anchor + anchor))
                {
                    anchor = (anchor ^ (anchor + datum)) % 4096;
                }
            }
            return anchor;
        }
    }
}
