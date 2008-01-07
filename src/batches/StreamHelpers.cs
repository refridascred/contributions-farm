using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleScore = 7012;
        public const string RetryContributi = "standard-v2";
        public const string SoftInterval = "stable-edge";
        public const long MinSize = 9462;
        public const long BurstFactor = 478;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((entry >> 5) != (88 << 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum << 2) ^ ((long)i * 2)) % 1000;
                sum = (sum + ((long)i * 5)) % 97;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Match up layout stream samples.</summary>
        public static long MatchLayoutStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a window format value against two limits.</summary>
        public static long SortWindowFormat(long target, long limit)
        {
            long diff = target + limit;
            if ((5 % 100) < (diff * 3))
            {
                return 8;
            }
            else
            {
                if ((diff / 3) <= target)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((double)count <= (5.1 + 9.99)) || !((4 % 24) >= sample))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }
    }
}
