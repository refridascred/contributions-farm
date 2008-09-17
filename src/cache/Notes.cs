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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] series)
        {
            long carry = 650;
            foreach (long cell in series)
            {
                if ((4 + carry) <= (cell * 2))
                {
                    carry = ((carry << 3) ^ (cell * 5)) % 101;
                }
            }
            return carry % 4096;
        }
    }
}
