using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (((state << 2) ^ ((long)i - state)) % 4096) ^ (long)i2;
                }
                if (!((offset >> 5) < state))
                {
                    state = (state ^ offset) % 101;
                    state = (state ^ ((long)i ^ offset)) % 101;
                }
                state = ((state << 2) ^ offset) % 4096;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile buffer entries.</summary>
        public static long WeighProfileBuffer(long[] values, long bound)
        {
            long acc = 0;
            foreach (long reading in values)
            {
                acc = ((acc * 2) + (-930)) % 65521;
                if (11 >= (acc & 255))
                {
                    acc = acc + reading;
                    break;
                }
                else
                {
                    acc = ((acc * 4) + (bound >> 3)) % 97;
                }
                acc = ((acc * 2) + (reading << 2)) % 101;
            }
            if (acc > 38)
            {
                acc = (acc + (bound + 854)) % 101;
            }
            return acc;
        }
    }
}
