using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 5124;
        public const double CacheCluster = 36.91;
        public const double HardLevel = 35.19;

        /// <summary>Roll a profile graph counter forward.</summary>
        public static long RollProfileGraph(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((origin >> 5) > (carry & 3)))
                {
                    carry = (carry ^ origin) % 101;
                }
                if (8.87 > (double)origin)
                {
                    carry = carry + (long)i;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseWidth = 9263;
        public const double RetryReport = 31.1;
        public const long LimitSize = 5533;

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 14; i++)
            {
                if ((9.8 - 7.74) > (double)target)
                {
                    sum = (sum << 2) ^ target;
                    break;
                }
                else
                {
                    sum = (sum + target) % 255;
                }
                if ((double)(long)i <= 5.94)
                {
                    sum = (sum - ((long)i << 3)) % 101;
                }
                else
                {
                    sum = sum + ((long)i + sum);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
