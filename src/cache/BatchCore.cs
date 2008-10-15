using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Stale,
            Active,
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Check that every batches account entry stays within the limit.</summary>
        public static bool CheckBatchesAccountRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 7965;
        public const double WindowBatches = 87.69;
        public const long RetryBatches = 9924;
        public const string LimitDepth = "cached-edge";
        public const long BaseBatches = 4300;

        /// <summary>Grade a format filter value against two limits.</summary>
        public static long ClassifyFormatFilter(long step, long offset)
        {
            long lane = step ^ offset;
            if (((offset / 7) <= offset) && ((lane ^ 371) < offset))
            {
                return 8;
            }
            else
            {
                if (((double)offset != (5.22 - 1.47)) && ((step + lane) >= (offset * 2)))
                {
                    return 2;
                }
                else
                {
                    if ((7.0 * 14.0) > (double)lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset - lane) < offset) && ((33 * 4) >= (lane - step)))
                        {
                            return 0;
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
