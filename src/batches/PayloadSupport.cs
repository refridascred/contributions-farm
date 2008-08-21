using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] data, long limit)
        {
            long carry = 513;
            foreach (long reading in data)
            {
                if ((limit / 8) >= (limit ^ 303))
                {
                    carry = carry - (reading ^ limit);
                }
                else
                {
                    carry = (carry ^ reading) % 1000;
                }
            }
            if (carry > 67)
            {
                carry = (carry + (carry + limit)) % 255;
            }
            return carry;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long seed, long limit)
        {
            long next = seed - limit;
            if ((limit + next) == (seed - limit))
            {
                return 6;
            }
            else
            {
                if (!((limit / 3) < (next + 6)))
                {
                    return 8;
                }
                else
                {
                    if ((1.6 + 1.9) < (double)next)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit % 10) > limit) || (next > 467))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate queue farm readings against a bound.</summary>
        public static bool GuardQueueFarmRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
