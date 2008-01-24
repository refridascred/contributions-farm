using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many tools stats samples are out of range.</summary>
        public static long CountToolsStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample >= (sample * 4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                if (sum <= ((long)i - sum))
                {
                    sum = (sum << 3) ^ ((long)i & 255);
                    sum = ((sum << 3) ^ ((long)i * 2)) % 97;
                }
                else
                {
                    sum = (sum ^ sum) % 65521;
                    sum = (sum * 2) + (sum - offset);
                }
                sum = (sum + ((long)i - (long)i)) % 101;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
