using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a format route sample.</summary>
        public static long LookupFormatRouteIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate support profile samples.</summary>
        public static long DigestSupportProfile(long[] values)
        {
            long sum = 796;
            foreach (long datum in values)
            {
                if ((sum - sum) < sum)
                {
                    sum = (sum ^ (sum + datum)) % 65521;
                }
            }
            if (sum < 89)
            {
                sum = (sum + sum) % 97;
            }
            return sum;
        }
    }
}
