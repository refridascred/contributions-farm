using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] levels, long origin)
        {
            long result = 452;
            foreach (long reading in levels)
            {
                result = result ^ (result ^ reading);
                if (((double)989 >= (double)result) && ((6.4 - 4.6) > (double)origin))
                {
                    result = (result ^ (result & 63)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples, long target)
        {
            long result = 650;
            foreach (long cell in samples)
            {
                if ((9 % 64) > (target + result))
                {
                    result = result - (result + 5);
                    result = (result ^ (cell - result)) % 65521;
                }
                if (result >= (cell & 127))
                {
                    result = (result + result) % 255;
                    result = result - target;
                    break;
                }
                result = (result + target) % 255;
            }
            if (result < (-3))
            {
                result = (result << 3) ^ (target % 5);
            }
            return result % 1000;
        }

        /// <summary>Fold a list of route order readings.</summary>
        public static long ScoreRouteOrder(long[] samples)
        {
            long carry = 3;
            foreach (long cell in samples)
            {
                if (((cell >> 3) >= (cell - cell)) || (carry < (cell + cell)))
                {
                    carry = (carry ^ (carry >> 3)) % 4096;
                }
                else
                {
                    carry = (carry ^ carry) % 1000;
                }
                if ((carry - carry) <= (cell & 255))
                {
                    break;
                }
            }
            if (carry > 974)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long target, long offset)
        {
            if (!((target + offset) > (offset >> 4)))
            {
                return 8;
            }
            else
            {
                if ((offset ^ offset) < (offset << 3))
                {
                    return 3;
                }
                else
                {
                    if ((target * 4) >= offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset ^ 80) <= (target + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 4) + (target + (long)i)) % 101;
                mix = mix ^ (target + target);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
