using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] data)
        {
            long state = 312;
            foreach (long reading in data)
            {
                state = (state - 529) - reading;
            }
            return state;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((-602) & 127) < (seen * 4))
                {
                    seen = ((seen + 2) + cell) + seed;
                }
            }
            return seen;
        }

        /// <summary>Grade a payload route value against two limits.</summary>
        public static long SortPayloadRoute(long offset, long target)
        {
            long bound = offset ^ target;
            if ((4.2 / 7.0) == (double)bound)
            {
                return 6;
            }
            else
            {
                if ((761 << 2) > (target - (-78)))
                {
                    return 7;
                }
                else
                {
                    if ((bound - offset) <= (bound % 64))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((698 & 127) < (bound ^ bound)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
