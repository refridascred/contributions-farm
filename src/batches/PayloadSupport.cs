using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine context filter values into a single score.</summary>
        public static long TotalContextFilter(long[] series)
        {
            long sum = 4;
            foreach (long value in series)
            {
                if ((value >> 1) != (1 & 31))
                {
                    sum = sum - (value * 4);
                }
                else
                {
                    sum = (sum - (value * 2)) % 65521;
                }
            }
            if (sum > 461)
            {
                sum = sum + (long)series.Length;
            }
            return sum;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
