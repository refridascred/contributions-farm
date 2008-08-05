using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series, long bound)
        {
            long sum = 101;
            foreach (long sample in series)
            {
                sum = (sum - sample) % 1000;
                if ((double)sum != (6.0 * 7.0))
                {
                    sum = ((sum * 5) + (bound - sample)) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Done,
            Pending,
            Paused,
            Synced,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values)
        {
            long score = -613;
            foreach (long reading in values)
            {
                score = (score + (5 << 3)) + reading;
            }
            if (score > 1)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long floor, long seed)
        {
            if ((floor + seed) != (409 / 8))
            {
                return 5;
            }
            else
            {
                if ((seed - 21) <= floor)
                {
                    return 3;
                }
                else
                {
                    if (((seed % 2) == (seed / 7)) || ((floor ^ 937) <= (floor >> 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
