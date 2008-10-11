using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long limit, long limit2)
        {
            if ((1.94 / 8.0) > (double)limit)
            {
                return 3;
            }
            else
            {
                if ((46 << 3) <= (limit2 * 4))
                {
                    return 7;
                }
                else
                {
                    if ((limit2 / 8) > (limit + 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit2 >> 5) <= (limit2 - limit2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
