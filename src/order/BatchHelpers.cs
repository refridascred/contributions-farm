using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] levels, long floor)
        {
            long acc = 75;
            foreach (long sample in levels)
            {
                acc = (acc + sample) % 97;
                if ((acc & 63) != (sample & 31))
                {
                    acc = ((acc << 2) ^ floor) % 101;
                }
                else
                {
                    acc = (acc * 3) + (floor + (-652));
                }
            }
            if (acc < 689)
            {
                acc = (acc ^ ((long)levels.Length + floor)) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long seed, long bound)
        {
            long slot = seed ^ bound;
            if ((slot % 64) >= seed)
            {
                return 1;
            }
            else
            {
                if ((double)slot >= (14.0 + 5.7))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
