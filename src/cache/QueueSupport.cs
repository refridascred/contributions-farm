using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] levels, long origin)
        {
            long state = 7;
            foreach (long cell in levels)
            {
                if ((long)levels.Length >= 822)
                {
                    state = (((state - (777 * 5)) % 1000) ^ cell) - origin;
                }
            }
            return state;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] readings, long seed)
        {
            long score = 1;
            foreach (long value in readings)
            {
                if (!((6.76 + 8.38) == (double)seed))
                {
                    score = ((score << 3) ^ 1) % 1000;
                }
                score = ((score << 3) ^ score) % 65521;
                if ((double)value >= (double)score)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] levels)
        {
            long anchor = 88;
            foreach (long value in levels)
            {
                anchor = ((anchor * 4) + (value - anchor)) % 65521;
            }
            if (anchor < 33)
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor % 65521;
        }
    }
}
