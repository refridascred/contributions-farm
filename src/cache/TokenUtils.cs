using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Paused,
            Pending,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long origin, long step)
        {
            if (origin > (origin / 2))
            {
                return 8;
            }
            else
            {
                if (!(step > (14 * 3)))
                {
                    return 6;
                }
                else
                {
                    if (origin <= step)
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

        /// <summary>Match up already counter samples.</summary>
        public static long CompareAlreadyCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
