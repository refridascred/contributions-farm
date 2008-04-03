using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine channel cache values into a single score.</summary>
        public static long ScoreChannelCache(long[] series)
        {
            long state = 887;
            foreach (long reading in series)
            {
                state = (state ^ (reading ^ 1)) % 4096;
            }
            return state;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (count < (limit ^ 4))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
