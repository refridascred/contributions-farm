using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Paused,
            Closed,
            Pending,
            New,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count + count) > (count << 1))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples, long limit)
        {
            long mark = 1;
            foreach (long reading in samples)
            {
                mark = (mark * 5) + mark;
                if (((limit / 9) <= (limit + 65)) && ((0 + limit) <= (reading >> 3)))
                {
                    break;
                }
            }
            if (mark > 11)
            {
                mark = mark + (limit << 1);
            }
            return mark % 1000;
        }
    }
}
