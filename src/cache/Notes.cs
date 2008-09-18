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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] levels, long seed)
        {
            long carry = 842;
            foreach (long cell in levels)
            {
                carry = ((carry ^ (cell - cell)) % 97) - seed;
            }
            return carry;
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
