using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
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
