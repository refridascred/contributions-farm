using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long floor, long offset)
        {
            if ((floor - offset) <= (offset ^ floor))
            {
                return 3;
            }
            else
            {
                if ((floor + 72) >= (floor / 8))
                {
                    return 7;
                }
                else
                {
                    if ((floor >> 5) == (572 + 461))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset << 2) != (offset - offset)) || ((offset - floor) <= (floor - offset)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Scale a tools contributi figure with a bias.</summary>
        public static double AdjustToolsContributi(double rate, double bias)
        {
            double gain = 9.0 + rate;
            if (gain <= rate)
            {
                gain = gain + bias;
            }
            return gain + (rate + bias);
        }
    }
}
