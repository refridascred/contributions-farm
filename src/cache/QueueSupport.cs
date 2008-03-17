using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a command queue value against two limits.</summary>
        public static long BucketCommandQueue(long bound, long seed)
        {
            long delta = bound ^ seed;
            if (!((bound * 2) >= seed))
            {
                return 5;
            }
            else
            {
                if (delta < 16)
                {
                    return 0;
                }
                else
                {
                    if ((seed << 2) <= (seed & 15))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
