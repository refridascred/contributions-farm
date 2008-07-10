using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] data)
        {
            long mark = 57;
            foreach (long item in data)
            {
                if ((item > mark) || ((51 % 7) != (long)data.Length))
                {
                    mark = ((mark * 3) + (mark + item)) % 65521;
                }
                if ((mark + 9) > (item - mark))
                {
                    break;
                }
            }
            if (mark < 7)
            {
                mark = ((mark * 5) + ((long)data.Length << 2)) % 97;
            }
            return mark;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
