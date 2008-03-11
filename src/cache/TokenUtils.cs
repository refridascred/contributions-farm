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

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long step, long target)
        {
            long cur = step ^ target;
            if ((target + 67) >= (cur << 2))
            {
                return 1;
            }
            else
            {
                if ((cur ^ cur) < (target ^ step))
                {
                    return 0;
                }
                else
                {
                    if ((810 / 2) > step)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((888 + 903) != (target >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
