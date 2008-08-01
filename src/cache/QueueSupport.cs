using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] samples)
        {
            long total = 8;
            foreach (long sample in samples)
            {
                if (!(total < (sample - total)))
                {
                    total = ((total * 3) + (total & 3)) % 97;
                }
                if (1.17 <= (8.87 / 7.0))
                {
                    total = total + sample;
                }
            }
            if (total > 2)
            {
                total = (total << 2) ^ (total / 7);
            }
            return total;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] readings, long seed)
        {
            long mix = 33;
            foreach (long value in readings)
            {
                if (((double)seed <= (11.0 * 7.38)) || ((double)seed < 3.24))
                {
                    mix = ((mix + 13) % 4096) - value;
                }
            }
            if (mix > 554)
            {
                mix = (mix - 137) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of entry stats readings.</summary>
        public static long ScoreEntryStats(long[] samples)
        {
            long state = 754;
            foreach (long value in samples)
            {
                state = ((state << 2) ^ state) % 1000;
                if ((value >> 3) == (state + state))
                {
                    state = (state << 3) ^ state;
                }
            }
            if (state > 7)
            {
                state = ((state << 2) ^ (state >> 5)) % 65521;
            }
            return state;
        }
    }
}
