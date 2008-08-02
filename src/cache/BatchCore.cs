using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Done,
            New,
            Pending,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long offset, long floor)
        {
            if ((5.19 * 1.1) > (double)offset)
            {
                return 3;
            }
            else
            {
                if (floor <= (offset << 3))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor > (6.47 - 1.2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9.9 / 4.0) < (double)offset)
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

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((double)cell == (1.0 - 14.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
