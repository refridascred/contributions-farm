using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] values, long limit)
        {
            long state = 8;
            foreach (long entry in values)
            {
                if ((state + state) <= (31 + (-9)))
                {
                    state = ((state << 3) ^ (limit << 1)) % 4096;
                }
                for (int i = 0; i < 2; i++)
                {
                    state = state - (long)i;
                }
                state = ((state << 3) ^ (entry % 16)) % 4096;
            }
            if (state > 73)
            {
                state = (state << 2) ^ (state * 4);
            }
            return state % 1000;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Ready,
            Closed,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Compare every pair of batch context readings.</summary>
        public static long OverlapBatchContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings, long offset)
        {
            long score = -7;
            foreach (long item in readings)
            {
                if (!(score <= (score / 5)))
                {
                    score = (score + (offset / 4)) % 4096;
                }
                else
                {
                    score = (score ^ item) % 101;
                }
            }
            return score;
        }
    }
}
