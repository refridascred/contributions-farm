using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next order cache value from a seed.</summary>
        public static long SeriesOrderCache(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((double)limit != (double)9)
                {
                    sum = sum ^ 823;
                    break;
                }
                else
                {
                    sum = sum ^ (limit - sum);
                }
                sum = (sum << 2) ^ (921 >> 4);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] series, long bound)
        {
            long mark = 859;
            foreach (long cell in series)
            {
                if (!(625 < (0 ^ mark)))
                {
                    mark = ((mark << 3) ^ bound) - cell;
                }
                if ((double)bound > (19.0 / 2.0))
                {
                    mark = mark + (mark % 60);
                }
            }
            if (mark > 800)
            {
                mark = (mark - (mark / 5)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Ready,
            Queued,
            Locked,
            New,
        }
    }
}
