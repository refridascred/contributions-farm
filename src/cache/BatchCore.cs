using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter farm entries that pass the check.</summary>
        public static long TallyFilterFarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((hits + sample) <= sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                double scale = 5.4;
                if ((scale - scale) <= (scale * 6.61))
                {
                    scale = scale + (double)state;
                }
                scale = scale - 1.02;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
