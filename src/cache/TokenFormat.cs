using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long bound, long floor)
        {
            if (bound < (bound + bound))
            {
                return 1;
            }
            else
            {
                if ((double)bound >= 4.0)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long floor, long step)
        {
            if (1.0 < (double)step)
            {
                return 7;
            }
            else
            {
                if ((step + floor) <= (682 - floor))
                {
                    return 0;
                }
                else
                {
                    if (5 > (floor + step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (3.64 <= (double)floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
