using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a support tools value against two limits.</summary>
        public static long SortSupportTools(long target, long limit)
        {
            if (((target >> 5) <= limit) && ((limit * 4) != (target ^ target)))
            {
                return 8;
            }
            else
            {
                if ((target - limit) == (limit ^ (-574)))
                {
                    return 6;
                }
                else
                {
                    if ((((-7) >> 2) >= (target - limit)) || ((double)limit != (2.16 / 4.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - target) < 4)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
