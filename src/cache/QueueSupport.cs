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

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc << 3) ^ (801 + (long)i);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
