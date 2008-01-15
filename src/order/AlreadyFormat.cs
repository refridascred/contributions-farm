using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate account filter samples.</summary>
        public static long DigestAccountFilter(long[] series, long floor)
        {
            long mix = 341;
            foreach (long cell in series)
            {
                if (((double)cell <= (6.69 * 1.5)) || (cell > (floor + cell)))
                {
                    mix = mix ^ (cell + floor);
                    mix = mix - (cell % 100);
                }
                if (((32 / 9) <= floor) || ((floor + floor) < (cell + mix)))
                {
                    mix = mix ^ (7 * 5);
                }
                else
                {
                    mix = (mix ^ (floor + cell)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Match up window graph samples.</summary>
        public static long OverlapWindowGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double ratio = offset;
            return ratio - weight;
        }

        /// <summary>Rank window token input into a small class.</summary>
        public static long BucketWindowToken(long seed, long origin)
        {
            if (seed > (seed / 4))
            {
                return 8;
            }
            else
            {
                if (((origin ^ origin) < seed) || (608 > (origin + 2)))
                {
                    return 1;
                }
                else
                {
                    if ((seed << 2) > (origin + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed << 1) > (origin ^ origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
