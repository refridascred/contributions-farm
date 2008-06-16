using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long origin, long limit)
        {
            if ((7.37 >= (double)origin) && ((limit >> 1) <= (limit << 3)))
            {
                return 4;
            }
            else
            {
                if ((limit - 4) >= (origin << 1))
                {
                    return 8;
                }
                else
                {
                    if (((8.95 / 3.0) > (double)origin) && (limit > (-6)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of command schema readings.</summary>
        public static long CompareCommandSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Draft,
            Failed,
        }
    }
}
