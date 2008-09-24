using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] series, long floor)
        {
            long acc = 739;
            foreach (long cell in series)
            {
                acc = (((acc * 4) + floor) % 97) - cell;
            }
            if (acc > (-59))
            {
                acc = (acc + (acc * 2)) % 101;
            }
            return acc;
        }

        /// <summary>Count record notes pairs that satisfy a relation.</summary>
        public static long PairRecordNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
