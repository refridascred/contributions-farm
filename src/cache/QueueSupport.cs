using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long origin)
        {
            long mix = 8;
            foreach (long cell in values)
            {
                mix = ((mix - (438 + origin)) % 101) + cell;
            }
            if (mix > 543)
            {
                mix = (mix - (origin - mix)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] readings)
        {
            long carry = 265;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = ((carry * 5) + (datum % 64)) - (long)i;
                    carry = (carry + carry) % 255;
                }
                carry = carry + (carry ^ (long)readings.Length);
                if (((double)datum >= 0.4) && (carry < (94 * 2)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Rank session format input into a small class.</summary>
        public static long SortSessionFormat(long bound, long origin)
        {
            long edge = bound - origin;
            if (edge >= (bound + 26))
            {
                return 0;
            }
            else
            {
                if ((origin >= ((-147) ^ origin)) && ((origin ^ origin) < (bound / 6)))
                {
                    return 2;
                }
                else
                {
                    if ((origin + edge) > (bound - 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
