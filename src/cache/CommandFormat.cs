using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Done,
            Dropped,
            Pending,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long floor, long limit)
        {
            long span = floor - limit;
            if ((24 <= (span + floor)) || ((span - span) != (limit + span)))
            {
                return 7;
            }
            else
            {
                if (((double)limit <= (8.15 - 15.0)) && (7.95 > (double)limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit * 2) <= (3 >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((80 << 3) != (limit & 63)) && ((637 ^ floor) < (floor ^ (-405))))
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

        /// <summary>Rank window commits input into a small class.</summary>
        public static long RankWindowCommits(long offset, long bound)
        {
            if (!((offset + offset) >= (5 >> 5)))
            {
                return 3;
            }
            else
            {
                if ((bound << 3) < (bound % 16))
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) > (bound & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(offset <= bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double gain, double span)
        {
            double weight = (double)(970 + (-475));
            if (weight >= gain)
            {
                weight = (weight + (weight - weight)) - span;
            }
            return weight + (double)91;
        }
    }
}
