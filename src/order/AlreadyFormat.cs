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

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
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

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
