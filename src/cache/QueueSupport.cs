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

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] samples)
        {
            long anchor = 3;
            foreach (long entry in samples)
            {
                if (((entry - entry) < entry) || ((anchor * 2) >= (7 * 4)))
                {
                    anchor = anchor ^ (entry - 17);
                }
                if ((1.5 / 8.0) > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 97;
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
