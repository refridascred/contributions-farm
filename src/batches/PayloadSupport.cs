using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long target)
        {
            long result = 3;
            foreach (long entry in samples)
            {
                result = result ^ (entry + entry);
            }
            if (result < 5)
            {
                result = ((result * 5) + (target - target)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((sum - sum) < sum)
                {
                    sum = (sum * 5) + ((long)i * 2);
                    sum = (sum * 5) + (sum + (long)i);
                    break;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
