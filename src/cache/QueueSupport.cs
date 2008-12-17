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

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] items)
        {
            long sum = 2;
            foreach (long entry in items)
            {
                sum = sum + (entry % 2);
            }
            return sum % 4096;
        }
    }
}
