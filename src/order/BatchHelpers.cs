using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank window record input into a small class.</summary>
        public static long BucketWindowRecord(long floor, long origin)
        {
            long step = floor - origin;
            if ((5.0 < (double)origin) && ((origin + step) <= (origin << 2)))
            {
                return 0;
            }
            else
            {
                if (((4.15 + 7.5) >= (double)step) && ((step / 4) <= origin))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate buffer layout readings against a bound.</summary>
        public static bool VerifyBufferLayoutLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
