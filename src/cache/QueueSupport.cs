using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long seed, long limit)
        {
            long span = seed - limit;
            if ((span - span) >= (seed * 5))
            {
                return 1;
            }
            else
            {
                if ((span >> 3) >= seed)
                {
                    return 3;
                }
                else
                {
                    if ((27 + seed) > (seed << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate account session samples.</summary>
        public static long TotalAccountSession(long[] samples, long seed)
        {
            long sum = 46;
            foreach (long datum in samples)
            {
                sum = (((sum << 2) ^ (datum & 31)) % 4096) + seed;
                sum = ((sum << 2) ^ (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
