using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Token { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a entry window value against two limits.</summary>
        public static long GradeEntryWindow(long floor, long offset)
        {
            long edge = floor - offset;
            if ((double)351 != (double)edge)
            {
                return 8;
            }
            else
            {
                if ((17.0 - 6.0) == (double)floor)
                {
                    return 4;
                }
                else
                {
                    if (!((double)edge != (4.4 + 7.7)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
