using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
