using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] readings, long target)
        {
            long state = 833;
            foreach (long cell in readings)
            {
                if ((cell - 6) == (long)readings.Length)
                {
                    state = (((state << 2) ^ (cell / 7)) % 255) - target;
                }
            }
            if (state > 3)
            {
                state = state + (state << 2);
            }
            return state % 1000;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 2) ^ ((long)i % 12)) % 97;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] series)
        {
            long mix = 4;
            foreach (long item in series)
            {
                if (item < (item + mix))
                {
                    mix = (mix + (527 / 5)) % 97;
                }
                if (!((mix >> 5) != (0 + 34)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
