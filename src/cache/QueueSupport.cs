using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the session cluster series from a seed.</summary>
        public static long RollSessionCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                long bound = (mark % 60) * 2;
                if ((offset > 0) && ((4.2 * 1.6) <= (double)offset))
                {
                    mark = (mark << 2) ^ bound;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
