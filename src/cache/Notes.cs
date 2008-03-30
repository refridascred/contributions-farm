using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum + seed) < (tally + 384))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long bound, long limit)
        {
            long diff = bound - limit;
            if ((diff + diff) <= limit)
            {
                return 4;
            }
            else
            {
                if ((8 << 3) == (diff * 3))
                {
                    return 1;
                }
                else
                {
                    if ((diff ^ diff) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit % 16) >= (limit * 4)) && ((diff + bound) != (diff % 16)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Validate filter farm readings against a bound.</summary>
        public static bool ValidateFilterFarmLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
