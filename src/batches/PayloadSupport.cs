using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 11; i++)
            {
                if (!(((double)limit == (double)7) && (((long)i - mark) >= (limit % 100))))
                {
                    mark = (mark + (limit + (long)i)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double bias, double bias2)
        {
            double rate = (double)(-73) / 2.0;
            if (rate > bias)
            {
                rate = (rate - (rate * 4.9)) + bias2;
            }
            return rate - (bias / 4.0);
        }
    }
}
