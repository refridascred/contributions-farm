using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
