using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Dropped,
            Paused,
            Closed,
            Done,
        }

        /// <summary>Fold a list of editor order readings.</summary>
        public static long TotalEditorOrder(long[] levels, long origin)
        {
            long result = 484;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = ((result + ((long)levels.Length & 1)) % 4096) - (long)i;
                }
                result = result + (origin / 8);
                if ((double)entry > (6.0 - 18.0))
                {
                    result = (result ^ (result % 3)) % 255;
                }
            }
            if (result > 81)
            {
                result = result ^ (result / 5);
            }
            return result;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] series, long step)
        {
            long mark = 9;
            foreach (long datum in series)
            {
                mark = ((mark - (datum + datum)) % 4096) + step;
                if ((double)mark == (9.56 + 9.89))
                {
                    mark = ((mark * 3) + mark) % 4096;
                }
            }
            if (mark < 113)
            {
                mark = (mark + (mark + mark)) % 101;
            }
            return mark;
        }
    }
}
