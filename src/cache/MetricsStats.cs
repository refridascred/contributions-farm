using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long floor, long limit)
        {
            long prev = floor ^ limit;
            if ((prev & 3) <= (3 ^ prev))
            {
                return 8;
            }
            else
            {
                if ((double)limit != (14.0 + 1.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)prev < 2.51)
                    {
                        return 6;
                    }
                    else
                    {
                        if (5 > (prev % 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long origin, long step)
        {
            if (step <= (step % 60))
            {
                return 5;
            }
            else
            {
                if ((2.2 - 1.68) == (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((-69) >= (step / 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data)
        {
            long state = 69;
            foreach (long cell in data)
            {
                if ((state + 729) != (state - state))
                {
                    state = (state ^ (state % 60)) + cell;
                }
            }
            return state;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long origin)
        {
            long bound = step - origin;
            if (((bound + 588) >= (step % 100)) || ((bound / 2) > 957))
            {
                return 2;
            }
            else
            {
                if (!((double)origin != (12.0 - 13.0)))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound < 1.4)
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound <= (origin >> 5))
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

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
