using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((double)(long)i >= (8.14 - 16.0))
                {
                    mix = ((mix * 5) + (long)i) % 255;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Closed,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] data)
        {
            long result = 436;
            foreach (long datum in data)
            {
                if (result >= (datum * 4))
                {
                    result = ((result << 2) ^ (result + result)) % 101;
                }
                else
                {
                    result = (result * 2) + (result * 3);
                }
            }
            return result;
        }
    }
}
