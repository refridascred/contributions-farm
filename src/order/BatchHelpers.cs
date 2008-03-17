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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading & 255) < tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
