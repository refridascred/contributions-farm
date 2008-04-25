using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine cluster order values into a single score.</summary>
        public static long CombineClusterOrder(long[] items, long limit)
        {
            long mix = 789;
            foreach (long cell in items)
            {
                mix = (mix ^ (cell * 4)) - limit;
            }
            return mix % 1000;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= 2.83)
                {
                    count = (count + 1) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count + entry) != (entry ^ 270))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
