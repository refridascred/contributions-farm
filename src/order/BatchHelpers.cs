using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long origin, long step)
        {
            long span = origin - step;
            if ((step >> 1) < step)
            {
                return 7;
            }
            else
            {
                if ((double)71 < (double)span)
                {
                    return 1;
                }
                else
                {
                    if ((double)step <= 9.04)
                    {
                        return 0;
                    }
                    else
                    {
                        if (step >= 560)
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

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)(long)series.Length < (double)tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Queued,
            Pending,
            Failed,
            Locked,
        }
    }
}
