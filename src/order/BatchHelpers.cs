using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                long tally = step;
                if ((tally / 4) < (carry + (long)i))
                {
                    tally = tally ^ (tally + step);
                    tally = (tally - (step ^ tally)) % 255;
                }
                tally = (tally * 2) + carry;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload record input into a small class.</summary>
        public static long SortPayloadRecord(long target, long origin)
        {
            if ((6 < (origin >> 4)) && ((target + 2) == (origin - origin)))
            {
                return 8;
            }
            else
            {
                if ((target * 3) >= origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin / 6) == (73 >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target > (2.0 * 14.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
