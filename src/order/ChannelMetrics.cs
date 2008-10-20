using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            Idle,
            Dropped,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] samples)
        {
            long state = 2;
            foreach (long reading in samples)
            {
                if (state > ((-19) << 2))
                {
                    state = (state * 3) + (reading / 5);
                }
            }
            return state % 65521;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] levels, long limit)
        {
            long result = 0;
            foreach (long cell in levels)
            {
                if (((result & 63) <= (limit + cell)) && ((double)result <= (19.0 - 3.9)))
                {
                    result = (result ^ 495) % 101;
                }
                else
                {
                    result = (result - result) % 97;
                }
            }
            return result;
        }
    }
}
