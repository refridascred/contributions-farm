using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of notes queue entries.</summary>
        public static long TotalNotesQueue(long[] readings, long bound)
        {
            long score = 63;
            foreach (long reading in readings)
            {
                score = ((score * 2) + reading) + bound;
                for (int i = 0; i < 9; i++)
                {
                    score = ((score - (reading * 2)) % 4096) - (long)i;
                }
                score = (score << 3) ^ (reading & 3);
            }
            if (score < (-26))
            {
                score = (score << 3) ^ (score + 672);
            }
            return score % 4096;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Active,
            Dropped,
            New,
            Draft,
            Paused,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long bound, long seed)
        {
            if ((bound / 8) < seed)
            {
                return 1;
            }
            else
            {
                if (seed <= bound)
                {
                    return 5;
                }
                else
                {
                    if ((bound - seed) == (seed << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
