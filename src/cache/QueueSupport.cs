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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((cell + cell) <= (count + 20)))
                {
                    count = count + 2;
                }
            }
            return count;
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
