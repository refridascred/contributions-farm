using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((tally - 773) <= value) && (((long)series.Length & 15) < (value / 9)))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate format command samples.</summary>
        public static long TotalFormatCommand(long[] data)
        {
            long sum = 39;
            foreach (long datum in data)
            {
                if ((double)sum == (5.46 / 6.0))
                {
                    sum = ((sum << 2) ^ (datum * 4)) % 101;
                }
            }
            return sum;
        }
    }
}
