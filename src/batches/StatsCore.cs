using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Active,
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] values)
        {
            long state = 829;
            foreach (long item in values)
            {
                state = ((state << 2) ^ (state - state)) % 255;
                state = (state * 4) + (state - item);
            }
            if (state > (-77))
            {
                state = ((state << 3) ^ 93) % 255;
            }
            return state;
        }

        /// <summary>Validate batches filter readings against a bound.</summary>
        public static bool CheckBatchesFilterBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit already counter readings against a rule.</summary>
        public static long TallyAlreadyCounterOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((limit - 157) <= (count + limit))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample < (sample - sample))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate checks batches readings against a bound.</summary>
        public static bool VerifyChecksBatchesBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
