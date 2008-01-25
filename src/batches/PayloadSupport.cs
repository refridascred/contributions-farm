using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Locked,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long step, long target)
        {
            long offset = step - target;
            if (((offset - offset) < (510 + offset)) && ((target * 2) < target))
            {
                return 3;
            }
            else
            {
                if (!((target + 73) < (target * 2)))
                {
                    return 6;
                }
                else
                {
                    if (((0.48 + 0.65) != (double)step) || (target >= (target / 9)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.67 / 8.0) < 7.9)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double scale, double floor)
        {
            double scale2 = floor * 1.74;
            return (scale2 - 0.4) + scale;
        }
    }
}
