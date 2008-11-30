using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long bound, long floor)
        {
            if ((floor < (bound ^ 68)) || ((double)floor > (19.0 + 1.1)))
            {
                return 2;
            }
            else
            {
                if (((floor >> 3) > 38) || ((0.7 + 14.0) != (double)bound))
                {
                    return 5;
                }
                else
                {
                    if (((double)bound >= (16.0 * 5.0)) || ((floor << 1) > 39))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor << 2) <= (bound & 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
