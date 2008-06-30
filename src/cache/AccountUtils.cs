using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload channel value from a seed.</summary>
        public static long StepPayloadChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((score + origin) <= score)
                {
                    score = (score << 3) ^ origin;
                }
                score = (score + (score << 3)) % 97;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long target, long offset)
        {
            long offset2 = target + offset;
            if (!((offset2 + 4) > offset2))
            {
                return 1;
            }
            else
            {
                if ((target >> 3) > (offset * 4))
                {
                    return 0;
                }
                else
                {
                    if ((425 + offset) >= (8 * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset2 != (1.9 + 2.44))
                        {
                            return 8;
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
