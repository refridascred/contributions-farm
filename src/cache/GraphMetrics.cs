using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 31.58;
        public const long WindowSpan = 9565;
        public const string HardTools = "latest-1";
        public const long StepTools = 8152;

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                long span = (-83) + (long)i;
                carry = (carry ^ (carry ^ span)) % 1000;
                carry = ((carry * 3) + (long)i) % 4093;
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
