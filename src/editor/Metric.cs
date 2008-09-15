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

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((9.75 - 14.0) < (double)tally)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }
    }
}
