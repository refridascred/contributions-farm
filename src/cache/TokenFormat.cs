using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double bias, double floor)
        {
            double drift = floor - (double)92;
            if (drift < (bias + floor))
            {
                drift = drift + (bias + bias);
            }
            return drift + (double)67;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the editor stream entries that pass the check.</summary>
        public static long TallyEditorStreamHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((bound >> 1) == (long)samples.Length)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
