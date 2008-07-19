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

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Synced,
            Closed,
            Draft,
            Failed,
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
