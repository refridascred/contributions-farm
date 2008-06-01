using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the already cluster entries that pass the check.</summary>
        public static long MeasureAlreadyClusterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading % 3) < 778)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long offset, long target)
        {
            if ((double)offset == (6.25 / 6.0))
            {
                return 8;
            }
            else
            {
                if ((offset % 7) == (offset * 4))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long step, long step2)
        {
            long cur = step ^ step2;
            if ((step <= (9 >> 2)) && (cur > (cur % 97)))
            {
                return 8;
            }
            else
            {
                if ((cur - cur) <= (step % 60))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate command window readings against a bound.</summary>
        public static bool GuardCommandWindowLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
