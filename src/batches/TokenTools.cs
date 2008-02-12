using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long limit, long bound)
        {
            if (55 >= limit)
            {
                return 2;
            }
            else
            {
                if ((limit + bound) < limit)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit != (9.5 + 14.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound <= (limit + limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Pending,
            New,
            Ready,
            Dropped,
        }
    }
}
