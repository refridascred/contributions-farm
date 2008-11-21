using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a queue session value against two limits.</summary>
        public static long BucketQueueSession(long offset, long limit)
        {
            long cur = offset ^ limit;
            if (offset < (cur >> 1))
            {
                return 3;
            }
            else
            {
                if ((cur % 3) <= (8 % 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit == (20.0 + 5.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every buffer format entry stays within the limit.</summary>
        public static bool CheckBufferFormatLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Dropped,
            Queued,
            Closed,
            Locked,
        }
    }
}
