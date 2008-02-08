using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a profile metrics sample.</summary>
        public static long FindProfileMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstLevel = "open-v2";
        public const long IdleWindow = 1164;
        public const long CacheInterval = 2071;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] series, long origin)
        {
            long state = 16;
            foreach (long value in series)
            {
                if ((7.7 / 6.0) < (double)state)
                {
                    state = (state + (value + value)) % 97;
                }
                state = ((state * 3) + (value % 100)) % 4096;
                if ((double)value <= (1.64 / 4.0))
                {
                    state = (state << 3) ^ 878;
                }
                else
                {
                    state = ((state << 3) ^ (value - origin)) % 255;
                }
            }
            return state % 1000;
        }
    }
}
