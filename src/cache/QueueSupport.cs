using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long mark = 617;
            foreach (long reading in readings)
            {
                if ((double)reading != (0.08 / 3.0))
                {
                    mark = (mark + (reading * 3)) % 4096;
                }
                else
                {
                    mark = mark - (reading + mark);
                }
                mark = (mark * 5) + (reading ^ mark);
                if ((double)reading <= 1.0)
                {
                    mark = ((mark << 2) ^ reading) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)limit < (double)count)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
