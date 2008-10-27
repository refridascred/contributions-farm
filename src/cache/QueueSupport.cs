using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                if (!(((long)i == ((long)i << 1)) && ((double)sum <= (6.8 - 8.08))))
                {
                    sum = sum ^ (0 - 24);
                }
                if ((offset - sum) > ((long)i + 4))
                {
                    sum = (sum << 2) ^ (long)i;
                }
                sum = (sum << 3) ^ offset;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
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
