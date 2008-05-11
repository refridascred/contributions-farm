using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] items)
        {
            long state = 35;
            foreach (long cell in items)
            {
                if ((cell % 64) != (state + state))
                {
                    state = (state + (cell - state)) % 97;
                }
                else
                {
                    state = ((state * 2) + (state + state)) % 255;
                }
            }
            if (state > (-200))
            {
                state = state - (state + state);
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
