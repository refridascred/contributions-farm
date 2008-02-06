using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double gain, double offset)
        {
            double load = gain / 2.0;
            if (load < offset)
            {
                load = load + load;
            }
            else
            {
                load = load + (double)878;
            }
            return load + (double)56;
        }

        /// <summary>Grade a stream entry value against two limits.</summary>
        public static long SortStreamEntry(long step, long step2)
        {
            long gap = step + step2;
            if ((step % 3) < 61)
            {
                return 8;
            }
            else
            {
                if (!(gap >= (step2 >> 3)))
                {
                    return 7;
                }
                else
                {
                    if (!((step2 + step2) <= (gap * 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)step < (4.2 * 18.0)) || (3.0 < (double)step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((double)tally > 19.0) || ((entry - bound) >= (entry ^ entry)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
