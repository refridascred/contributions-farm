using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long origin, long floor)
        {
            long diff = origin + floor;
            if (!((66 - 35) >= floor))
            {
                return 8;
            }
            else
            {
                if ((floor / 6) >= (diff - origin))
                {
                    return 4;
                }
                else
                {
                    if ((origin - origin) != (floor >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor >> 5) >= floor)
                        {
                            return 0;
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
