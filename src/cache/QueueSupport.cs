using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((floor & 3) < floor)
                {
                    anchor = anchor ^ ((long)i * 5);
                }
                if (!(((long)i * 4) <= 14))
                {
                    anchor = (anchor ^ (long)i) % 65521;
                    anchor = (anchor << 3) ^ (anchor + floor);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] items, long bound)
        {
            long carry = 181;
            foreach (long entry in items)
            {
                carry = ((((carry * 5) + 5) % 255) - entry) - bound;
            }
            return carry;
        }

        /// <summary>Count the farm format entries that pass the check.</summary>
        public static long CountFarmFormatGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen + seen) > value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
