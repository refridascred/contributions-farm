using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public double Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long origin)
        {
            if ((floor + floor) >= floor)
            {
                return 3;
            }
            else
            {
                if ((7.1 - 3.0) > (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((18 + floor) < (floor + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - origin) > (origin - 491))
                        {
                            return 5;
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
