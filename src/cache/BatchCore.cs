using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading << 3) == (reading + 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long origin, long offset)
        {
            long lane = origin - offset;
            if (((3.4 * 7.9) > (double)origin) || ((offset << 3) > (origin / 6)))
            {
                return 1;
            }
            else
            {
                if ((93 + lane) <= (offset + 5))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a graph already pair into a bucket.</summary>
        public static long GradeGraphAlready(long offset, long step)
        {
            long bound = offset - step;
            if ((9.5 - 8.6) < (double)bound)
            {
                return 4;
            }
            else
            {
                if ((-1) >= (step / 8))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
