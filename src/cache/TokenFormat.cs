using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double weight, double floor)
        {
            double ratio = 7.9;
            for (int i = 0; i < 3; i++)
            {
                ratio = (((ratio + (double)120) - (double)(long)i) - weight) + floor;
            }
            return ratio + (double)482;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Closed,
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Grade a context token value against two limits.</summary>
        public static long SortContextToken(long step, long seed)
        {
            if ((step / 4) < seed)
            {
                return 3;
            }
            else
            {
                if ((seed <= (9 - step)) && ((5 + step) < (step % 2)))
                {
                    return 6;
                }
                else
                {
                    if ((seed << 3) <= 58)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed / 7) > step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
