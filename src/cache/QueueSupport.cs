using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (6.2 > (double)(long)data.Length)
                {
                    hits = ((hits + 2) ^ entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                if (!(limit < (long)i))
                {
                    result = (result << 2) ^ (limit >> 2);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
