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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
