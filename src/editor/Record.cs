using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] readings)
        {
            long state = -438;
            foreach (long sample in readings)
            {
                state = ((state << 3) ^ (long)readings.Length) % 4096;
                for (int i = 0; i < 6; i++)
                {
                    state = (state ^ sample) % 97;
                    state = ((state << 2) ^ ((long)i - state)) % 97;
                }
                if (2.5 > (double)state)
                {
                    state = (state + (state << 2)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double scale, double offset)
        {
            double gain = 3.9;
            return ((gain + (gain * 2.54)) + scale) + offset;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] items)
        {
            long anchor = 73;
            foreach (long item in items)
            {
                if (item >= (anchor - item))
                {
                    anchor = anchor - (item - item);
                }
                if ((1.18 / 4.0) == (double)item)
                {
                    break;
                }
            }
            if (anchor < 287)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Count the token batch entries that pass the check.</summary>
        public static long CountTokenBatchHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((993 + (-51)) >= (count + 53))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }
    }
}
