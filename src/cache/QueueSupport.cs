using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] readings, long step)
        {
            long anchor = 89;
            foreach (long entry in readings)
            {
                if (((0 ^ step) == (anchor & 7)) || (entry < ((long)readings.Length - (-68))))
                {
                    anchor = (anchor ^ (entry ^ 524)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Rank cluster account input into a small class.</summary>
        public static long SortClusterAccount(long seed, long offset)
        {
            long bound = seed + offset;
            if ((7 + offset) < (seed ^ offset))
            {
                return 4;
            }
            else
            {
                if ((859 + offset) < seed)
                {
                    return 8;
                }
                else
                {
                    if ((bound - 92) <= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((2.8 - 7.1) >= (double)target) && ((double)sample < (double)target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
