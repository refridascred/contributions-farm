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

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long offset, long seed)
        {
            if ((double)offset == (double)seed)
            {
                return 6;
            }
            else
            {
                if ((offset + seed) > (seed ^ 93))
                {
                    return 2;
                }
                else
                {
                    if ((8 - offset) <= (seed - 682))
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

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
