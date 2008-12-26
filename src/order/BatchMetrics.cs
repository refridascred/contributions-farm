using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Retry,
            Queued,
            Paused,
            Pending,
        }

        /// <summary>Grade a editor batch value against two limits.</summary>
        public static long RankEditorBatch(long limit, long limit2)
        {
            long bound = limit ^ limit2;
            if ((limit2 & 1) <= bound)
            {
                return 8;
            }
            else
            {
                if ((limit + limit2) > (limit - limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit2 + bound) >= (limit2 >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound << 1) < bound) || ((double)limit2 >= (double)bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long bound, long bound2)
        {
            if (((7.18 * 6.0) < (double)bound) && (bound <= (47 >> 4)))
            {
                return 3;
            }
            else
            {
                if ((bound << 2) >= bound2)
                {
                    return 1;
                }
                else
                {
                    if ((4.3 * 6.9) < (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound2 ^ 5) != (bound2 - bound2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long seed, long limit)
        {
            if (((-5) > seed) || ((double)limit < (double)seed))
            {
                return 5;
            }
            else
            {
                if ((double)seed < 5.5)
                {
                    return 7;
                }
                else
                {
                    if ((5.0 / 3.0) <= (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Locked,
            Done,
        }
    }
}
