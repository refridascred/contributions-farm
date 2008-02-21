using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings)
        {
            long total = -927;
            foreach (long reading in readings)
            {
                if ((7 + reading) != (reading >> 4))
                {
                    total = (total ^ (total + 880)) % 1000;
                }
                else
                {
                    total = (total ^ (reading - total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i % 5) > ((long)i & 255))
                {
                    result = (result * 3) + 4;
                }
                result = (result ^ limit) % 65521;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
