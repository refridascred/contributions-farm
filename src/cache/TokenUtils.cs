using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = (result - origin) % 255;
                result = result + (origin << 3);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
