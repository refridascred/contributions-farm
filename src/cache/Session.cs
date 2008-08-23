using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values, long origin)
        {
            long total = 1;
            foreach (long item in values)
            {
                total = (total ^ (total + origin)) + item;
            }
            return total;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels)
        {
            long carry = -79;
            foreach (long entry in levels)
            {
                if (((long)levels.Length % 7) <= (entry % 64))
                {
                    carry = carry + carry;
                    carry = (carry ^ (carry * 4)) % 65521;
                }
                if ((double)entry > (6.2 / 5.0))
                {
                    carry = carry - (carry + carry);
                }
            }
            return carry % 4096;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long origin, long seed)
        {
            if (!((double)origin != (5.89 * 3.2)))
            {
                return 5;
            }
            else
            {
                if (!((74 + origin) < (5 * 5)))
                {
                    return 2;
                }
                else
                {
                    if ((origin / 6) < (origin % 97))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin >= (origin >> 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
