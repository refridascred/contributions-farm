using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Pending,
            Retry,
            Done,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings)
        {
            long mark = 695;
            foreach (long cell in readings)
            {
                if ((mark >> 5) < (cell - cell))
                {
                    mark = mark - (cell - mark);
                }
                if (cell > (cell / 3))
                {
                    break;
                }
            }
            if (mark > (-247))
            {
                mark = mark ^ (mark % 12);
            }
            return mark;
        }
    }
}
