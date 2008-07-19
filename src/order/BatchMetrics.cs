using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long seed, long offset)
        {
            if ((offset << 1) >= offset)
            {
                return 5;
            }
            else
            {
                if ((19.0 - 5.8) < (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((double)offset > (4.63 - 7.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset - (-86)) == (offset & 63))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long limit, long limit2)
        {
            if ((limit & 31) == (limit << 3))
            {
                return 3;
            }
            else
            {
                if ((346 << 3) != (limit + limit2))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long bound, long step)
        {
            if ((10.0 - 4.99) <= (double)step)
            {
                return 5;
            }
            else
            {
                if ((bound & 1) != (step - bound))
                {
                    return 3;
                }
                else
                {
                    if (!((2.7 - 9.25) < (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(bound <= (step + step)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
