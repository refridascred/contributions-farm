using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                if (20.0 < (double)acc)
                {
                    acc = (acc - (offset + acc)) % 97;
                }
                acc = (acc + (acc - offset)) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Done,
            Closed,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long bound, long floor)
        {
            if ((bound / 8) >= 4)
            {
                return 4;
            }
            else
            {
                if ((8 - bound) <= (floor ^ bound))
                {
                    return 3;
                }
                else
                {
                    if (!((bound + bound) != (floor * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound / 3) != (bound << 1)) && ((floor * 3) <= (floor - 7)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
