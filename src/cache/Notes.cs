using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Locked,
            Done,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items, long bound)
        {
            long anchor = 902;
            foreach (long item in items)
            {
                anchor = (anchor ^ (bound * 2)) - item;
            }
            if (anchor < 753)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long offset, long target)
        {
            if (2.2 > (double)target)
            {
                return 4;
            }
            else
            {
                if ((offset << 3) == (target - offset))
                {
                    return 7;
                }
                else
                {
                    if ((target & 127) != (offset / 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((offset - target) > (target ^ offset)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long limit, long bound)
        {
            if (!(bound >= (bound + limit)))
            {
                return 2;
            }
            else
            {
                if ((0.73 * 6.0) > (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((4.6 / 3.0) == (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit >= bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
